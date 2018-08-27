﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sales.Interfaces
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}
