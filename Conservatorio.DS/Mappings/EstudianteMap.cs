using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class EstudianteMap : SubclassMap<Estudiante>
    {
        public EstudianteMap()
        {
            KeyColumn("IdEstudiante");
            Map(x => x.Tipo).Not.Nullable();
            References(x => x.Encargado).Column("IdEncargado");
            HasManyToMany(x => x.Instrumentos).Cascade.All().Table("EstudianteInstrumento").ParentKeyColumn("IdEstudiante").ChildKeyColumn("IdInstrumento");
        }
    }
}
