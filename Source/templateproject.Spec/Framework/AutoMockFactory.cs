namespace templateproject.Framework
{
    using System;
    using Moq;

    public static class AutoMockFactory
    {
        /// <summary>
        /// Default mock type is RhinoMocksAAA
        /// </summary>
        public static ClassUnderTest<TClass> CreateTarget<TClass>() where TClass : class
        {
            return CreateTarget<TClass>(MockBehavior.Default);
        }

        public static ClassUnderTest<TClass> CreateTarget<TClass>(MockBehavior mockBehavior) where TClass : class
        {
            var factory = new MockRepository(mockBehavior);
            var container = new AutoMockContainer(factory);

            //AutoMocker<TClass> mocker;
            //ServiceLocator serviceLocator;
            //switch (framework)
            //{
            //    case AutoMockType.RhinoMocksAAA:
            //        mocker = new RhinoAutoMocker<TClass>(MockMode.AAA);
            //        serviceLocator = new RhinoMocksAAAServiceLocator();
            //        break;
            //    case AutoMockType.RhinoMocksClassic:
            //        mocker = new RhinoAutoMocker<TClass>(MockMode.RecordAndReplay);
            //        serviceLocator = new RhinoMocksClassicServiceLocator();
            //        break;
            //    case AutoMockType.Moq:
            //        mocker = new MoqAutoMocker<TClass>();
            //        serviceLocator = new MoqServiceLocator();
            //        break;
            //    default:
            //        throw new ArgumentOutOfRangeException("framework");
            //}

            return new ClassUnderTest<TClass>(container);
            //return new ClassUnderTest<TClass>(mocker, serviceLocator);
        }
    }
}