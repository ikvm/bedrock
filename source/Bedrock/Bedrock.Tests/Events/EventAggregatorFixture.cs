using Bedrock.Events;
using Xunit;

namespace Bedrock.Tests.Events
{
    public class EventAggregatorFixture
    {
        [Fact]
        public void GetReturnsSingleInstancesOfSameEventType()
        {
            var eventAggregator = new EventAggregator();
            var instance1 = eventAggregator.GetEvent<MockEventBase>();
            var instance2 = eventAggregator.GetEvent<MockEventBase>();

            Assert.Same(instance2, instance1);
        }

        public class MockEventBase : EventBase { }
    }
}