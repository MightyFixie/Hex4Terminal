﻿namespace Hex4Terminal {
	abstract class Region {
		public long Size {
			// Розмір зміненої ділянки файлу.
			get; protected set;
		}
		public long SizeDelta {
			// На стільки змінюється розмір файлу після внесення зміни.
			get; protected set;
		}
		public long Position {
			// Де було змінено файл.
			get; protected set;
		}
	}
}
