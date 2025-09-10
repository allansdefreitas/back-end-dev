﻿
namespace ScreenSound.Shared.Modelos.Modelos;

public class Genre
{
    public int Id { get; set; }
    public string? Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Nome: {Name} - Descrição: {Description}";
    }
}