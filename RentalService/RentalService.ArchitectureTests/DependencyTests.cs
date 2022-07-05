using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;
using RentalService.Domain;
using RentalService.Entities;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace RentalService.ArchitectureTests
{
    public class DependencyTests
    {
        private static readonly Architecture _architecture = new ArchLoader()
                .LoadAssemblies(
                typeof(User).Assembly,
                typeof(Rents).Assembly)
                .Build();

        private readonly IObjectProvider<IType> Entities =
            Classes().That().ResideInNamespace("RentalService.Entities").As("Entities");

        private readonly IObjectProvider<IType> Domain =
            Classes().That().ResideInNamespace("RentalService.Domain").As("Domain");

        [Fact]
        public void DomainToEntitiesRelationship()
        {
            IArchRule domainDependsOnEntities =
                Types().That().Are(Domain).Should().DependOnAny(Entities);

            IArchRule entitiesDontDependOnDomain =
                Types().That().Are(Entities).Should().NotDependOnAny(Domain);

            IArchRule combined =
                domainDependsOnEntities
                .And(entitiesDontDependOnDomain);

            combined.Check(_architecture);
        }
    }
}