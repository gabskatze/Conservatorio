using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class InstrumentoMap : ClassMap<Instrumento>
    {
        public InstrumentoMap()
        {
            Id(x => x.IdInstrumento).GeneratedBy.Identity();
            Map(x => x.NombreInstrumento).Not.Nullable();
        }
    }
}
