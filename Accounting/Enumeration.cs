﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Accounting
{
    public abstract class Enumeration : IComparable
    {
        readonly int _value;

        protected Enumeration()
        {
        }

        protected Enumeration(int value, string displayName)
        {
            _value = value;
            DisplayName = displayName;
        }

        public int Value => _value;
        public string DisplayName { get; }

        public override string ToString()
        {
            return DisplayName;
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration, new()
        {
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

        public static IEnumerable<Enumeration> GetAll(Type type)
        {
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            return fields.Select(f => f.GetValue(null)).Cast<Enumeration>();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Enumeration otherValue))
            {
                return false;
            }

            var typeMatches = GetType() == obj.GetType();
            var valueMatches = _value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public static int AbsoluteDifference(Enumeration firstValue, Enumeration secondValue)
        {
            var absoluteDifference = Math.Abs(firstValue.Value - secondValue.Value);
            return absoluteDifference;
        }

        public static T FromValue<T>(int value) where T : Enumeration, new()
        {
            var matchingItem = parse<T, int>(value, "value", item => item.Value == value);
            return matchingItem;
        }

        public static T FromDisplayName<T>(string displayName) where T : Enumeration, new()
        {
            var matchingItem = parse<T, string>(displayName, "display name", item => item.DisplayName == displayName);
            return matchingItem;
        }

        static T parse<T, K>(K value, string description, Func<T, bool> predicate) where T : Enumeration, new()
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);

            if (matchingItem != null) return matchingItem;

            var message = $"'{value}' is not a valid {description} in {typeof(T)}";
            throw new ApplicationException(message);

        }

        public int CompareTo(object other)
        {
            return Value.CompareTo(((Enumeration)other).Value);
        }
    }
}
