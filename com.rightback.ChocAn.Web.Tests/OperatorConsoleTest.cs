// <copyright file="OperatorConsoleTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.rightback.ChocAn.Web;

namespace com.rightback.ChocAn.Web.Tests
{
    /// <summary>This class contains parameterized unit tests for OperatorConsole</summary>
    [PexClass(typeof(OperatorConsole))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class OperatorConsoleTest
    {
    }
}
