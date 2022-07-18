using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;
using RentalService.Entities;
using RentalService.UseCases.Rents;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace RentalService.ArchitectureTests
{
    public class DependencyTests
    {
        private static readonly Architecture _architecture = new ArchLoader()
                .LoadAssemblies(
                typeof(User).Assembly,
                typeof(GetRentsRequest).Assembly)
                .Build();

        private readonly IObjectProvider<IType> Entities =
            Classes().That().ResideInNamespace("RentalService.Entities").As("Entities");

        private readonly IObjectProvider<IType> Domain =
            Classes().That().ResideInNamespace("RentalService.Domain").As("Domain");

        private readonly IObjectProvider<IType> Console =
            Classes().That().ResideInNamespace("RentalService.Console").As("Console");

        private readonly IObjectProvider<IType> DataAccess =
            Classes().That().ResideInNamespace(nameof(RentalService.NonPersistingDataAccess)).As("DataAccess");

        [Fact]
        public void EntitiesRelationships()
        {
            IArchRule dependencies =
                Types().That().Are(Entities).Should().OnlyDependOnTypesThat().Are(Entities)
                .Or().Types().That().Are(Entities).Should().OnlyDependOnTypesThat().HaveFullNameContaining("System.");

            dependencies.Check(_architecture);
        }

        [Fact]
        public void DomainRelationships()
        {
            IArchRule dependencies =
                Types().That().Are(Domain).Should().DependOnAny(Domain)
                .Or().Types().That().Are(Domain).Should().DependOnAny(Entities);

            IArchRule dependencies2 =
                Types().That().Are(Domain).Should().NotDependOnAny(DataAccess);

            var combined = dependencies
                .And(dependencies2);

            combined.Check(_architecture);
        }

        [Fact]
        public void ConsoleRelationships()
        {
            IArchRule dpendencies =
                Types().That().Are(Console).Should().NotDependOnAny(Entities);

            dpendencies.Check(_architecture);
        }
    }
}