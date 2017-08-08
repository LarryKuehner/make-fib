#region Copyright
// <copyright file="MakeFib.cs" company="AVI-SPL">
// Copyright (C) AVI-SPL. All Rights Reserved.
// The intellectual and technical concepts contained herein are proprietary to AVI-SPL, Inc. and subject to AVI-SPL’s standard software license agreement.
// These materials may not be copied, reproduced, distributed or disclosed, in whole or in part, in any way without the written permission of an authorized
// representative of AVI-SPL. All references to AVI-SPL, Inc. shall also be references to AVI-SPL, Inc.’s affiliates.
// </copyright>
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace libMakeFib
{
    public class MakeFib
    {
        private int currentNumber;
        private int previousNumber;

        public delegate void NumberChangedHandler(object o, FibEventArgs e);
        public event NumberChangedHandler onNumberChanged;

        public MakeFib()
        {
            currentNumber = 1;
            previousNumber = 0;
        }

        public void NextNumber()
        {
            int temp = currentNumber;

            currentNumber = currentNumber + previousNumber;
            previousNumber = temp;

            if (onNumberChanged != null)
                onNumberChanged(this, new FibEventArgs((uint)currentNumber));
        }
    }
}