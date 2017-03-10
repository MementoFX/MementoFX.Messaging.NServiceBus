using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpTestsEx;

namespace Memento.Messaging.NServiceBus.Tests
{
    [TestClass]
    public class NServiceBusEventDispatcherFixture
    {
        [TestMethod]
        public void Ctor_should_throw_ArgumentNullException_on_null_bus_and_value_of_parameter_should_be_bus()
        {
            Executing.This(() => new NServiceBusEventDispatcher(null))
                .Should()
                .Throw<ArgumentNullException>()
                .And
                .ValueOf
                .ParamName
                .Should()
                .Be
                .EqualTo("bus");
        }
    }
}
