using System;

namespace State.State
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;
        readonly Random _randomWinner = new Random();

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            
            var winner = _randomWinner.Next(10);
            if (winner == 0 && _gumballMachine.NumberOfGumballs > 1)
                _gumballMachine.SetState(_gumballMachine.WinngeState);
            else
                _gumballMachine.SetState(_gumballMachine.SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
