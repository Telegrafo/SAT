﻿using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;
using System;


namespace SAT.Contabilidad.Polizas._1._1
{
    public class Transferencia
    {
        [XmlAttribute("CtaOri")]
        public string CtaOri { get; set; }

        [XmlAttribute("BancoOriNal")]
        public string BancoOriNal { get; set; }

        [XmlAttribute("BancoOriExt")]
        public string BancoOriExt { get; set; }

        [XmlAttribute("CtaDest")]
        public string CtaDest { get; set; }

        [XmlAttribute("BancoDestNal")]
        public string BancoDestNal { get; set; }

        [XmlAttribute("BancoDestExt")]
        public string BancoDestExt { get; set; }

        [XmlAttribute("Fecha", DataType = "date")]
        public string Fecha { get; set; }

        [XmlAttribute("Benef")]
        public string Benef { get; set; }

        [XmlAttribute("RFC")]
        public string RFC { get; set; }

        [XmlAttribute("Monto", DataType = "decimal")]
        public decimal Monto { get; set; }

        [XmlAttribute("Moneda")]
        public string Moneda { get; set; }

        [XmlAttribute("TipCamb", DataType = "decimal")]
        public decimal TipCamb { get; set; }
    }
}
