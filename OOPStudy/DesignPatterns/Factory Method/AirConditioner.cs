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

            foreach (AirConditionerMode action in Enum.GetValues(typeof(AirConditionerMode)))
            {
                var factory = (AirConditionerModeFactory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(AirConditionerMode), action) + "Factory"));
                _modesFactories.Add(action, factory);
            }

            #endregion
        }

        public static AirConditioner InitializeFactories() => new AirConditioner();

        public IAirConditionerMode ExecuteMode(AirConditionerMode action, double temperature) => _modesFactories[action].Create(temperature);
    }
}
