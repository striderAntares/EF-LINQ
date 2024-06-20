using System;
using System.Collections.Generic;

namespace _04_TelefonRehberiCodeFirstIntro.Models;

public partial class Kisiler
{
    public int KisiId { get; set; }

    public string? KisiAdi { get; set; }

    public string? KisiSoyadi { get; set; }

    public string? KisiTelefonu { get; set; }
}
