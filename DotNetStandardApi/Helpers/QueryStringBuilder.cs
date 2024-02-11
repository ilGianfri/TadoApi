﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KoenZomers.Tado.Api.Helpers
{
    public class QueryStringBuilder
    {
        private readonly Dictionary<string, string> _parameters = [];

        public bool HasKeys
        {
            get
            {
                return _parameters.Count > 0;
            }
        }

        public char? StartCharacter { get; set; }

        public char SeperatorCharacter { get; set; }

        public char KeyValueJoinCharacter { get; set; }

        public string this[string key]
        {
            get
            {
                return _parameters.TryGetValue(key, out string value) ? value : null;
            }
            set
            {
                _parameters[key] = value;
            }
        }

        public string[] Keys
        {
            get
            {
                return [.. _parameters.Keys];
            }
        }

        public QueryStringBuilder()
        {
            StartCharacter = new char?();
            SeperatorCharacter = '&';
            KeyValueJoinCharacter = '=';
        }

        public QueryStringBuilder(string key, string value)
        {
            this[key] = value;
        }

        public void Clear()
        {
            _parameters.Clear();
        }

        public bool ContainsKey(string key)
        {
            return _parameters.ContainsKey(key);
        }

        public void Add(string key, string value)
        {
            _parameters[key] = value;
        }

        public void Remove(string key)
        {
            _parameters.Remove(key);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            foreach (KeyValuePair<string, string> keyValuePair in _parameters)
            {
                if (stringBuilder.Length == 0)
                {
                    char? startCharacter = StartCharacter;
                    if ((startCharacter.HasValue ? startCharacter.GetValueOrDefault() : new int?()).HasValue)
                        stringBuilder.Append(StartCharacter);
                }
                if (stringBuilder.Length > 0)
                {
                    int num = stringBuilder[^1];
                    char? startCharacter = StartCharacter;
                    if ((num != (int)startCharacter.GetValueOrDefault() ? 1 : (!startCharacter.HasValue ? 1 : 0)) != 0)
                        stringBuilder.Append(SeperatorCharacter);
                }
                stringBuilder.Append(keyValuePair.Key);
                stringBuilder.Append('=');
                stringBuilder.Append(Uri.EscapeDataString(keyValuePair.Value));
            }
            return stringBuilder.ToString();
        }
    }
}