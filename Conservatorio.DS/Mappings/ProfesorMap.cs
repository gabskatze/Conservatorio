using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class ProfesorMap : SubclassMap<Profesor>
    {
        public ProfesorMap()
        {
            KeyColumn("IdProfesor");
            Map(x => x.GradoAcademico);
            HasManyToMany(x => x.Instrumentos).Cascade.All().Table("ProfesorInstrumento").ParentKeyColumn("IdProfesor").ChildKeyColumn("IdInstrumento");
            HasMany(x => x.Clases).Cascade.All().KeyColumn("IdProfesor");
        }

    }
}
