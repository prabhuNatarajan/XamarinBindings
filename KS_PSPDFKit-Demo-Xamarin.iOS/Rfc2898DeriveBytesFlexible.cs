using System;
using System.Text;
using System.Security.Cryptography;
using Mono.Security.Cryptography;

namespace PSPDFKitDemoXamarin.iOS
{
	/// <summary>
	/// A version of Rfc2898DeriveBytes which allows definition of the hashing algorithm.
	/// If none is specifief, SHA1 is used.
	/// </summary>
	public class Rfc2898DeriveBytesFlexible : DeriveBytes {

		private const int defaultIterations = 1000;

		private int _iteration;
		private byte[] _salt;
		private HMAC _hmac;
		private byte[] _buffer;
		private int _pos;
		private int _f;

		// constructors

		public Rfc2898DeriveBytesFlexible (string password, byte[] salt, HMAC hmac = null) 
			: this (password, salt, defaultIterations, null)
		{
		}

		public Rfc2898DeriveBytesFlexible (string password, byte[] salt, int iterations, HMAC hmac = null) 
		{
			if (password == null)
				throw new ArgumentNullException ("password");

			Salt = salt;
			IterationCount = iterations;
			if (hmac == null) {
				_hmac = new HMACSHA1 ();
			}
			else {
				_hmac = hmac;
			}
			_hmac.Key = Encoding.UTF8.GetBytes (password);
		}

		public Rfc2898DeriveBytesFlexible (byte[] password, byte[] salt, int iterations, HMAC hmac = null) 
		{
			if (password == null)
				throw new ArgumentNullException ("password");

			Salt = salt;
			IterationCount = iterations;
			if (_hmac == null) {
				_hmac = new HMACSHA1 ();
			}
			else {
				_hmac = hmac;
			}
			_hmac.Key = password;
		}

		public Rfc2898DeriveBytesFlexible (string password, int saltSize, HMAC hmac = null)
			: this (password, saltSize, defaultIterations, null)
		{
		}

		public Rfc2898DeriveBytesFlexible (string password, int saltSize, int iterations, HMAC hmac = null)
		{
			if (password == null)
				throw new ArgumentNullException ("password");
			if (saltSize < 0)
				throw new ArgumentOutOfRangeException ("invalid salt length");

			Salt = KeyBuilder.Key (saltSize);
			IterationCount = iterations;

			if (hmac == null) {
				_hmac = new HMACSHA1 ();
			}
			else {
				_hmac = hmac;
			}
			_hmac.Key = Encoding.UTF8.GetBytes (password);
		}

		// properties

		public int IterationCount { 
			get { return _iteration; }
			set {
				if (value < 1)
					throw new ArgumentOutOfRangeException ("IterationCount < 1");

				_iteration = value; 
			}
		}

		public byte[] Salt { 
			get { return (byte[]) _salt.Clone (); }
			set {
				if (value == null)
					throw new ArgumentNullException ("Salt");
				if (value.Length < 8)
					throw new ArgumentException ("Salt < 8 bytes");

				_salt = (byte[])value.Clone (); 
			}
		}

		// methods

		private byte[] F (byte[] s, int c, int i) 
		{
			int hashBitSize =_hmac.HashSize / 8;

			s [s.Length - 4] = (byte)(i >> 24);
			s [s.Length - 3] = (byte)(i >> 16);
			s [s.Length - 2] = (byte)(i >> 8);
			s [s.Length - 1] = (byte)i;

			// this is like j=0
			byte[] u1 = _hmac.ComputeHash (s);
			byte[] data = u1;
			// so we start at j=1
			for (int j=1; j < c; j++) {
				byte[] un = _hmac.ComputeHash (data);
				// xor
				for (int k=0; k < hashBitSize; k++)
					u1 [k] = (byte)(u1 [k] ^ un [k]);
				data = un;
			}
			return u1;
		}

		public override byte[] GetBytes (int cb) 
		{
			int hashBitSize =_hmac.HashSize / 8;
			if (cb < 1)
				throw new ArgumentOutOfRangeException ("cb");

			int l = cb / hashBitSize;	// HMACSHA1 == 160 bits == 20 bytes
			int r = cb % hashBitSize;	// remainder
			if (r != 0)
				l++;		// rounding up

			byte[] result = new byte [cb];
			int rpos = 0;
			if (_pos > 0) {
				int count = Math.Min (hashBitSize - _pos, cb);
				Buffer.BlockCopy (_buffer, _pos, result, 0, count);
				if (count >= cb)
					return result;

				// If we are going to go over the boundaries
				// of the result on our l-1 iteration, reduce
				// l to compensate.
				if (((l-1) * hashBitSize + count) > result.Length)
					l--;

				_pos = 0;
				rpos = count;
			}

			byte[] data = new byte [_salt.Length + 4];
			Buffer.BlockCopy (_salt, 0, data, 0, _salt.Length);

			for (int i=1; i <= l; i++) {
				_buffer = F (data, _iteration, ++_f);
				// we may not need the complete last block
				int count = ((i == l) ? result.Length - rpos : hashBitSize);
				Buffer.BlockCopy (_buffer, _pos, result, rpos, count);
				rpos += _pos + count;
				_pos = ((count == hashBitSize) ? 0 : count);
			}

			return result;
		}

		public override void Reset () 
		{
			_buffer = null;
			_pos = 0;
			_f = 0;
		}
		#if NET_4_0
		protected override void Dispose (bool disposing)
		{
			Array.Clear (_buffer, 0, _buffer.Length);
			Array.Clear (_salt, 0, _salt.Length);
			_hmac.Clear ();
			base.Dispose (disposing);
		}
		#endif
	} 
}

