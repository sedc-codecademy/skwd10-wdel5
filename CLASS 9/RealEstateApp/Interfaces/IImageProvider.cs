﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Interfaces
{
    public interface IImageProvider
    {
        string GetImage();

        List<string> GetImages(int count);
    }
}
