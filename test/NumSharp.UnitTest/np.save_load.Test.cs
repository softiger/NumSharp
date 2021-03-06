﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumSharp.UnitTest.Creation;
using NumSharp;

namespace NumSharp.UnitTest
{
  [TestClass]
  public class NumpySaveLoad
  {
    [TestMethod]
    public void Run()
    {
      int[] x = { 1, 2, 3, 4, 5 };
      np.Save(x, @"test.npy");
      np.Save_Npz(x, @"test1.npz");
      np.Load<int[]>(@"test.npy");
      np.Load_Npz<int[]>(@"test1.npz");
    }

    [TestMethod]
    public void Float1DimArray()
    {
      float[] x = { 1.0f, 1.5f, 2.0f, 2.5f, 3.0f };
      np.Save(x, @"test_Float1DimArray.npy");
      np.Save_Npz(x, @"test_Float1DimArray.npz");
      np.Load<float[]>(@"test_Float1DimArray.npy");
      np.Load_Npz<float[]>(@"test_Float1DimArray.npz");
    }

    [TestMethod]
    public void Double1DimArray()
    {
      double[] x = { 1.0, 1.5, 2.0, 2.5, 3.0 };
      np.Save(x, @"test_Double1DimArray.npy");
      np.Save_Npz(x, @"test_Double1DimArray.npz");
      np.Load<double[]>(@"test_Double1DimArray.npy");
      np.Load_Npz<double[]>(@"test_Double1DimArray.npz");
    }
    
    [TestMethod]
    public void SaveAndLoadMultiDimArray()
    {
      int[,] x =  { {1,2}, {3,4} };
      np.Save(x, @"test_SaveAndLoadMultiDimArray.npy");
      np.Save_Npz(x, @"test_SaveAndLoadMultiDimArray.npz");
      np.Load<int[,]>(@"test_SaveAndLoadMultiDimArray.npy");
      np.Load_Npz<int[,]>(@"test_SaveAndLoadMultiDimArray.npz");
    }
  }
}
