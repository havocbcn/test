using LIS.Service;

namespace LIS.Domain.Tests {
    public abstract class BiochemistryTest : Test {
        public BiochemistryTest(IOperationFactory operationFactory) : base(operationFactory) {

        }

        public float BiochemistryProperty { get; internal set; }
    }
}