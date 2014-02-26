using System;
using State.State;

namespace State
{
    public class WinnerState:IState
    {
        private readonly GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crack");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }

        public void Dispense()
        {
            Console.WriteLine("You're winner! You get two gumballs for our quarter");
            _gumballMachine.ReleaseBall();
            if(_gumballMachine.NumberOfGumballs == 0)
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            else
            {
                _gumballMachine.ReleaseBall();
                if(_gumballMachine.NumberOfGumballs > 0)
                    _gumballMachine.SetState(_gumballMachine.NoQuarterState);
                else
                {
                    Console.WriteLine("Oops. out of gumballs!");
                    _gumballMachine.SetState(_gumballMachine.SoldOutState);
                }
            }

        }
    }
}
