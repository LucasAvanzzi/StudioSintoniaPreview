﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace StudioSintoniaPreview.Models
{
    public class UsuarioModel
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? Profissao { get; set; }

    }
}