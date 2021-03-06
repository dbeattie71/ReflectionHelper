﻿using System.Reflection;
using NUnit.Framework;
#if RHELPER
using ReflectionFramework;
using ReflectionFramework.Attributes;
using ReflectionFramework.Extensions;

namespace ReflectionHelperTests
#else
using DevExpress.Xpf.Core.ReflectionExtensions.Attributes;
using DevExpress.Xpf.Core.ReflectionExtensions;
using DevExpress.Xpf.Core.Internal;

namespace DevExpress.Xpf.Core.ReflectionExtensions.Tests
#endif
    {
    internal class StaticFulentAPITestObject {
        static string stringField;
        public static string PublicStringProperty { get; set; }
        private static string PrivateStringProperty { get; set; }

        public static string PublicMethod(string value) {
            return value;
        }

        static string PrivateMethod(string value) {
            return value;
        }
    }

    public interface IStaticFluentAPITestObject {
        string stringField { get; set; }
        string PublicStringProperty { get; set; }
        string PrivateStringProperty { get; set; }

        string PublicMethod(string value);
        string PrivateMethod(string value);
    }
    [TestFixture]
    public class StaticFluentAPITests {
        [Test]
        public void Simple() {
            var ti = ReflectionHelperExtensions.DefineWrapper<StaticFulentAPITestObject, IFluentAPITestObject>()
                .DefineProperty(x => x.PrivateStringProperty)
                .BindingFlags(BindingFlags.NonPublic)
                .EndMember()
                .DefineProperty(x => x.stringField)
                .BindingFlags(BindingFlags.NonPublic)
                .FieldAccessor()
                .EndMember()
                .DefineMethod(x => x.PrivateMethod(null))
                .BindingFlags(BindingFlags.NonPublic | BindingFlags.Public)
                .EndMember()
                .Create();
            Assert.AreEqual("hello", ti.PublicMethod("hello"));
            ti.stringField = "hello";
            Assert.AreEqual("hello", ti.stringField);
        }
    }
}