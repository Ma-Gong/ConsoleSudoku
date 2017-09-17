using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSudoku
{
    public enum CellState
    {
        defult = 1,     //can't be change
        blank,          //waitting for input
        error,          //change background in red
        userinput,      //different from the default
        guess           //show all the input-able
    }

    public enum InputValue
    {
        pending = 0,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine

    }

    public class Cell
    {
        private int row;
        private int column;
        private int group;
        private InputValue inputValue;
        private CellState state;

        public int Row
        {
            get => row;
            set
            {
                if((0 <= value)&&(value <= 8))
                {
                    row = value;
                }
                else
                {
                    //throw exception
                }
            }
        }

        public int Column
        {
            get => column;
            set
            {
                if((0 <= value) && (value <= 8))
                {
                    column = value;
                }
                else
                {
                    //throw exception
                }

            }
        }

        public InputValue InputValue
        {
            get => inputValue;
            set
            {
                if((value >= InputValue.one) && (value <= InputValue.nine))
                {
                    inputValue = value;
                }
                else
                {
                    inputValue = InputValue.pending;
                }
                
            }
        }
        public CellState State { get => state; set => state = value; }

        Cell() { }

        Cell(int row,int column)
        {

        }

        Cell(int row,int column, InputValue value)
        {

        }

        Cell(int row, int column, InputValue value,CellState state)
        {

        }

    }
}
