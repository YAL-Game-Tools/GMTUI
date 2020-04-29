using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace GMTUI {
	/// <summary>
	/// It's INI, but also it isn't.
	/// </summary>
	class StrangeIni {
		public List<StrangeIniSection> sections = new List<StrangeIniSection>();
		public StrangeIniSection topSection = new StrangeIniSection(null);
		public StrangeIni() {

		}
		public bool Load(string path) {
			string[] lines;
			try {
				lines = File.ReadAllLines(path);
			} catch (Exception) {
				return false;
			}
			var rxSection = new Regex(@"^\[(\w+)\]");
			var rxPair = new Regex(@"^(\w+)=(.*)");
			var section = topSection;
			foreach (string line in lines) {
				Match mt;
				if ((mt = rxSection.Match(line)).Success) {
					section = AddSection(mt.Groups[1].Value);
				} else if ((mt = rxPair.Match(line)).Success) {
					section.pairs[mt.Groups[1].Value] = mt.Groups[2].Value;
				}
			}
			return true;
		}
		public StrangeIniSection AddSection(string name) {
			var sct = new StrangeIniSection(name);
			sections.Add(sct);
			return sct;
		}
		public string Save(string path) {
			var b = new StringBuilder();
			//
			topSection.PrintTo(b);
			foreach (var sct in sections) sct.PrintTo(b);
			//
			var s = b.ToString();
			try {
				File.WriteAllText(path, s);
				return null;
			} catch (Exception) {
				return s;
			}
		}
	}
	public class StrangeIniSection {
		public string name;
		public List<string> keys = new List<string>();
		public Dictionary<string, string> pairs = new Dictionary<string, string>();
		public StrangeIniSection(string _name) {
			name = _name;
		}
		public string Get(string key, string defval = null) {
			string val;
			return pairs.TryGetValue(key, out val) ? val : defval;
		}
		public void Set(string key, string val) {
			if (!pairs.ContainsKey(key)) keys.Add(key);
			pairs[key] = val;
		}
		public void PrintTo(StringBuilder b) {
			if (name != null) b.Append($"[{name}]\r\n");
			foreach (var key in keys) {
				var val = pairs[key];
				if (val == null) continue;
				b.Append($"{key}={val}\r\n");
			}
		}
		public string this[string key] {
			get { return Get(key, null); }
			set { Set(key, value); }
		}
	}
}
