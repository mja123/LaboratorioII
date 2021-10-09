using System;

namespace ImprimibleDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato miContrato = new Contrato();
            Foto miFoto = new Foto();
            Documento miDocumento = new Documento();
            Impresora miImpresora = new Impresora();

            miImpresora.agregarImprimible(miDocumento);
            miImpresora.agregarImprimible(miContrato);
            miImpresora.agregarImprimible(miFoto);
            miImpresora.imprimirTodo();
        }
    }
}
