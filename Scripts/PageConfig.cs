using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PageInfoConfig
{
    public List<PageInfo> Pages;

    [Serializable]
    public class PageInfo
    {
        public Color Color;
        public string Header;
        public string Body;
    }
}