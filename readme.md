.NET-Enterprise-Template
========================

.NET용 프로젝트의 솔루션을 위한 Template 구축 프로젝트입니다.

Templify Package파일을 이용하여 솔루션을 빠르게 생성하고 작업할 수 있도록 할 지원할 예정입니다.
일련의 기능을 구축하고, 각 버전별로 GitHub Donwloader에 Templify Package file을 배포할 것입니다.


Development log
---------------

####2010-02-24

[Notes]

* type-named logger를 이용하도록 LogManager 수정 및 테스트
* NLog layout 변경 => 잘못된 callsite 대신 type-named logger의 logger name 출력


####~ 2010-02-22

[Notes]

* BDD Framework 구성 ([bdd](https://github.com/Dreameris/.NET-Enterprise-Template/tree/bdd) branch)
* 프로젝트의 모든 Layer에서 사용할 Infrastructure 구성 ([infra](https://github.com/Dreameris/.NET-Enterprise-Template/tree/infra) branch)
* Common Logging 라이브러리를 이용한 Logging 통합작업 ([infra-log](https://github.com/Dreameris/.NET-Enterprise-Template/tree/infra-log) branch)

[Todo]

* NAnt를 이용한 빌드 자동화 구성 ([buildautomation](https://github.com/Dreameris/.NET-Enterprise-Template/tree/buildautomation) branch)