namespace templateproject.Framework.Sample
{
    using Framework;
    using Moq;
    using Machine.Specifications;
    using It = Machine.Specifications.It;

    public interface IDependencyType
    {
        void DependencyMethod();
    }

    public class DependencyController
    {
        protected IDependencyType DependencyType { get; set; }

        public DependencyController(IDependencyType dependencyType)
        {
            DependencyType = dependencyType;
        }

        public void InvokeDependencyMethod()
        {
            DependencyType.DependencyMethod();
        }
    }

    [Subject(typeof(DependencyController), "invoke dependency method"), Tags("Sample.BDDFramework.Automock")]
    public class when_given_a_dependency_controller : SpecificationFor<DependencyController>
    {
        Establish context = () =>
                                {
                                    _dependencyType = AutoMocker.Get<IDependencyType>();
                                    _dependencyType.Setup(x => x.DependencyMethod()).Verifiable();
                                };
        
        Because of = () => ClassUnderTest.InvokeDependencyMethod();

        It should_call_dependency_method = () => _dependencyType.VerifyAll();

        private static Mock<IDependencyType> _dependencyType;
    }

    [Subject(typeof(DependencyController), "invoke dependency method"), Tags("Sample.BDDFramework.Automock")]
    public class when_given_a_dependency_controller_using_with_dependency_object : with_dependency_object
    {
        Establish context = () => DependencyType.Setup(x => x.DependencyMethod()).Verifiable();

        Because of = () => ClassUnderTest.InvokeDependencyMethod();

        It should_call_dependency_method = () => DependencyType.VerifyAll();
    }

    public class with_dependency_object : SpecificationFor<DependencyController>
    {
        protected static Mock<IDependencyType> DependencyType;

        public with_dependency_object()
        {
            DependencyType = AutoMocker.Get<IDependencyType>();
        }
    }
}