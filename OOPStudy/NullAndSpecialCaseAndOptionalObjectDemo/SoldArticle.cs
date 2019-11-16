using OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo;
using OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Common;
using OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules;
using OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Warranty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPStudy.SpecialCaseDemo
{
    class SoldArticle
    {
        public IWarranty MoneyBackGuarantee { get; private set; }
        public IWarranty ExpressWarranty { get; private set; }
        private IWarranty NotOperationalWarranty { get; }
        private Option<Part> Circuitry { get; set; } = Option<Part>.None();
        private IWarranty FailedCircuitryWarranty { get; set; }
        private IWarranty CircuitryWarranty { get; set; }
        private EDeviceStatus OperationalStatusByEnum { get; set; }

        private DeviceStatus OperationalStatus { get; set; }

        public SoldArticle(IWarranty moneyBack, IWarranty express, IWarrantyMapFactory rulesFactory)
        {
            if (moneyBack == null)
                throw new ArgumentNullException(nameof(moneyBack));
            if (express == null)
                throw new ArgumentNullException(nameof(express));

            this.MoneyBackGuarantee = moneyBack;
            this.ExpressWarranty = VoidWarranty.Value;
            this.NotOperationalWarranty = express;
            this.CircuitryWarranty = VoidWarranty.Value;

            // With objects methods calls
            this.OperationalStatus = DeviceStatus.AllFine();
            this.WarrantyMap = rulesFactory.Create(
                this.ClaimMoneyBack, this.ClaimNotOperationalWarranty, this.ClaimCircuitryWarranty);
        }

        private void ClaimMoneyBack(Action action)
        {
            this.MoneyBackGuarantee.Claim(DateTime.Now, action);
        }

        private void ClaimNotOperationalWarranty(Action action)
        {
            this.NotOperationalWarranty.Claim(DateTime.Now, action);
        }

        private void ClaimCircuitryWarranty(Action action)
        {
            this.Circuitry
                .Do(c => this.CircuitryWarranty.Claim(c.DefectDetectedOn, action));
        }

        public void InstallCircuitry(Part circuitry, IWarranty extendedWarranty)
        {
            //this.Circuitry = Option<Part>.Some(circuitry);
            //this.FailedCircuitryWarranty = extendedWarranty;
        }

        public void CircuitryNotOperational(DateTime detectedOn)
        {
            this.Circuitry.Do(circuitry =>
            {
                circuitry.MarkDefective(detectedOn);
                this.CircuitryWarranty = this.FailedCircuitryWarranty;
            });
        }

        #region With Enum

        public void InstallCircuitryWithEnum(Part circuitry, IWarranty extendedWarranty)
        {
            this.Circuitry = Option<Part>.Some(circuitry);
            this.FailedCircuitryWarranty = extendedWarranty;
            this.OperationalStatusByEnum &= ~EDeviceStatus.CircuitryFailed;
        }

        public void CircuitryNotOperationalWithEnum(DateTime detectedOn)
        {
            this.Circuitry.Do(circuitry =>
            {
                circuitry.MarkDefective(detectedOn);
                this.OperationalStatusByEnum |= EDeviceStatus.CircuitryFailed;
            });
        }

        public void VisibleDamageWithEnum()
        {
            this.OperationalStatusByEnum |= EDeviceStatus.VisiblyDamaged;
        }

        public void NotOperationalWithEnum()
        {
            this.OperationalStatusByEnum |= EDeviceStatus.NotOperational;
        }

        public void RepairedWithEnum()
        {
            this.OperationalStatusByEnum &= ~EDeviceStatus.NotOperational;
        }

        public void ClaimWarrantyWithEnum(Action onValidClaim)
        {
            switch (this.OperationalStatusByEnum)
            {
                case EDeviceStatus.AllFine:
                    this.MoneyBackGuarantee.Claim(DateTime.Now, onValidClaim);
                    break;
                case EDeviceStatus.NotOperational:
                case EDeviceStatus.NotOperational | EDeviceStatus.CircuitryFailed:
                case EDeviceStatus.NotOperational | EDeviceStatus.VisiblyDamaged:
                case EDeviceStatus.NotOperational | EDeviceStatus.VisiblyDamaged | EDeviceStatus.CircuitryFailed:
                    this.NotOperationalWarranty.Claim(DateTime.Now, onValidClaim);
                    break;
                case EDeviceStatus.VisiblyDamaged:
                    break;
                case EDeviceStatus.CircuitryFailed:
                case EDeviceStatus.VisiblyDamaged | EDeviceStatus.CircuitryFailed:
                    this.Circuitry
                        .Do(c => this.CircuitryWarranty.Claim(c.DefectDetectedOn, onValidClaim));
                    break;

            }
        }

        #endregion With Enum

        #region With Object Mapping

        public void InstallCircuitryWithObject(Part circuitry, IWarranty extendedWarranty)
        {
            this.Circuitry = Option<Part>.Some(circuitry);
            this.FailedCircuitryWarranty = extendedWarranty;
            this.OperationalStatus = this.OperationalStatus.CircuitryReplaced();
        }

        public void CircuitryNotOperationalWithObject(DateTime detectedOn)
        {
            this.Circuitry.Do(circuitry =>
            {
                circuitry.MarkDefective(detectedOn);
                this.OperationalStatus = this.OperationalStatus.CircuitryFailed();
            });
        }

        public void VisibleDamageWithObject()
        {
            this.OperationalStatus = this.OperationalStatus.WithVisibleDamage();
        }

        public void NotOperationalWithObject()
        {
            this.OperationalStatus = this.OperationalStatus.NotOperational();
        }

        public void RepairedWithObject()
        {
            this.OperationalStatus = this.OperationalStatus.Repaired();
        }

        public void ClaimWarrantyWithObject(Action onValidClaim)
        {
            this.WarrantyMap[this.OperationalStatus].Invoke(onValidClaim);
        }

        private IReadOnlyDictionary<DeviceStatus, Action<Action>> WarrantyMap { get; }


        #endregion With Object

        #region With Branching
        public bool IsOperational { get; private set; }
        public bool IsCircuitryOperational { get; private set; }
        public bool IsVisiblyDamaged { get; private set; }

        public void ClaimWarrantyWithBranching(Action onValidClaim)
        {
            bool moneyReturned = false;
            bool isAroundChristmas = this.IsAroundChristmas();

            if (isAroundChristmas)
            {
                this.MoneyBackGuarantee.Claim(DateTime.Now, () =>
                {
                    moneyReturned = true;
                    onValidClaim();
                });
            }

            if (!moneyReturned && !this.IsOperational)
            {
                this.NotOperationalWarranty.Claim(DateTime.Now, onValidClaim);
            }
            else if (!moneyReturned && !this.IsCircuitryOperational)
            {
                this.Circuitry
                    .Do(c => this.CircuitryWarranty.Claim(c.DefectDetectedOn, onValidClaim));
            }
            else if (!isAroundChristmas && !this.IsVisiblyDamaged)
            {
                this.MoneyBackGuarantee.Claim(DateTime.Now, onValidClaim);
            }
        }

        private bool IsAroundChristmas()
        {
            throw new NotImplementedException();
        }

        #endregion With Branching

        #region With Chain of Rule Objects

        private IWarrantyRules WarrantyRules { get; }

        public SoldArticle(IWarranty moneyBack, IWarranty express, IWarrantyRulesFactory rulesFactory)
        {
            if (moneyBack == null)
                throw new ArgumentNullException(nameof(moneyBack));
            if (express == null)
                throw new ArgumentNullException(nameof(express));

            this.MoneyBackGuarantee = moneyBack;
            this.ExpressWarranty = VoidWarranty.Value;
            this.NotOperationalWarranty = express;
            this.CircuitryWarranty = VoidWarranty.Value;

            this.WarrantyRules = rulesFactory.Create(
                this.ClaimMoneyBack, this.ClaimNotOperationalWarranty, this.ClaimCircuitryWarranty);
        }

        public void ClaimWarrantyWithRuleChaining(Action onValidClaim)
        {
            this.WarrantyRules.Claim(onValidClaim);
        }

        public void InstallCircuitryWithRuleChaning(Part circuitry, IWarranty extendedWarranty)
        {
            this.Circuitry = Option<Part>.Some(circuitry);
            this.FailedCircuitryWarranty = extendedWarranty;
            this.WarrantyRules.CircuitryOperational();
        }

        public void CircuitryNotOperationalWithRuleChaining(DateTime detectedOn)
        {
            this.WarrantyRules.CircuitryFailed();
        }
        public void VisibleDamageWithRuleChaining()
        {
            this.WarrantyRules.VisiblyDamaged();
        }

        public void NotOperationalWithRuleChaining()
        {
            this.WarrantyRules.NotOperational();
        }

        public void RepairedWithRuleChaining()
        {
            this.WarrantyRules.Operational();
        }


        #endregion With Chain of Rule Objects

        public void VisibleDamage()
        {
            //this.MoneyBackGuarantee = VoidWarranty.Value;
        }

        public void NotOperational()
        {
            //this.MoneyBackGuarantee = VoidWarranty.Value;
            //this.ExpressWarranty = this.NotOperationalWarranty;
        }

        public void Repaired()
        {

        }
    }
}
