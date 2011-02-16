namespace templateproject.Infrastructure.Log
{
    using Machine.Specifications;
    using Moq;
    using It=Machine.Specifications.It;

    [Subject(typeof(LogFactory), "create a logger for context of specification"), Tags("Infrastructure.Log")]
    public class when_given_a_log_factory
    {
        Because of = () => logger = LogFactory.GetSpecificationLogger();

        It should_call_getlogger_of_proxy;  // TODO : static method의 호출을 검증할 수 있는 방법을 찾아 적용해야 한다.
        It should_return_a_logger = () => logger.ShouldNotBeNull();

        private static ILog logger;
    }
}