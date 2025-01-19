using CommandPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Logic
{
    internal class TurnOnCommand : ICommand
    {
        private Light _light;

        public TurnOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.TurnOn();
        public void Undo() => _light.TurnOff();
    }
}
