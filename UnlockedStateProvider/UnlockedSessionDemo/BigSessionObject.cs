﻿using System;

namespace UnlockedSessionDemo
{
    [Serializable]
    public class BigSessionObject
    {
        //private const int MAX_VALUE = 1000000;

        public BigSessionObject(bool fillData = true)
        {
            if (fillData)
            {
                Bytes = BigBytez.Bytez;
                Content = ContentText.LoremIpsum;
            }
        }

        public byte[] Bytes { get; set; }

        public string Content { get; set; }
    }
}