using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AirConditioner
    {
        private readonly Dictionary<AirConditionerMode, AirConditionerModeFactory> _modesFactories;

        private AirConditioner()
        {
            #region Modes Creation

            _modesFactories = new Dictionary<AirConditionerMode, AirConditionerModeFactory>();

            foreach (AirConditionerMode mode in Enum.GetValues(typeof(AirConditionerMode)))
            {
                var factory = (AirConditionerModeFactory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(AirConditionerMode), mode) + "Factory"));
                _modesFactories.Add(mode, factory);
            }

            #endregion
        }

        public static AirConditioner InitializeFactories() => new AirConditioner();

        public IAirConditionerMode ExecuteMode(AirConditionerMode mode, double temperature) => _modesFactories[mode].Create(temperature);
    }
}
