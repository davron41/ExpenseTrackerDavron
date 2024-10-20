﻿using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Application.ViewModels.Category;

public class CategoryViewModel
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
    public CategoryType Type { get; init; }
}