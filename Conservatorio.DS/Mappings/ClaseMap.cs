using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class ClaseMap : ClassMap<Clase>
    {
        public ClaseMap()
        {
            Id(x => x.IdClase).GeneratedBy.Identity();
            Map(x => x.Dia).Not.Nullable();
            Map(x => x.Hora).Not.Nullable();
            References(x => x.Profesor).Not.Nullable().Column("IdProfesor").Not.LazyLoad();
            References(x => x.Curso).Not.Nullable().Column("IdCurso").Not.LazyLoad();
        }
    }
}
