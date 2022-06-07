﻿using System.Reflection;

namespace Ssp.Common.Extensions;

public static class AssemblyExtensions
{
    public static List<Type> FindDerivedTypes(this Assembly assembly, Type type) => assembly.GetTypes().Where(type.IsAssignableFrom).ToList();
}