using System;
using State.State;

namespace State
{
    public class GumballMachine
    {
        public int NumberOfGumballs { get; private set; }
        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }
        public IState WinngeState { get; set; }
        private IState _state;

        public GumballMachine(int numberOfGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinngeState = new WinnerState(this);

            NumberOfGumballs = numberOfGumballs;
            _state = NumberOfGumballs > 0 ? NoQuarterState : SoldOutState;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (NumberOfGumballs != 0)
                NumberOfGumballs--;
        }
    }
}
