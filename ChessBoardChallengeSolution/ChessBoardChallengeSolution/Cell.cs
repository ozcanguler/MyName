﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardChallengeSolution
{
    public class Cell
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        public bool CurrentlyOccupied { get; set; }
        public bool LegalNextMove { get; set; }
        public Cell(int x, int y)
        {
            RowNumber = x;
            ColumnNumber = y;
        }
    }
}
