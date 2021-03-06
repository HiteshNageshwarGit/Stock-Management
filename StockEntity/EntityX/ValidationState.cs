﻿namespace StockEntity.Helper
{
    public class ValidationState
    {
        public static int SUCCESS = 1;
        public static int WARNING = 0;
        public static int ERROR = -1;
        public int State { get; set; }
        public string StateMessage { get; set; }

        public ValidationState()
        {
            State = SUCCESS; // By default entity state is success
        }
    }
}
