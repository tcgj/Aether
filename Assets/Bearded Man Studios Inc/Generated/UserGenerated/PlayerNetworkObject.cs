using BeardedManStudios.Forge.Networking.Frame;
using BeardedManStudios.Forge.Networking.Unity;
using System;
using UnityEngine;

namespace BeardedManStudios.Forge.Networking.Generated
{
	[GeneratedInterpol("{\"inter\":[0.15,0.15,0.05,0.15,0,0,0,0,0.15]")]
	public partial class PlayerNetworkObject : NetworkObject
	{
		public const int IDENTITY = 12;

		private byte[] _dirtyFields = new byte[2];

		#pragma warning disable 0067
		public event FieldChangedEvent fieldAltered;
		#pragma warning restore 0067
		[ForgeGeneratedField]
		private Vector3 _position;
		public event FieldEvent<Vector3> positionChanged;
		public InterpolateVector3 positionInterpolation = new InterpolateVector3() { LerpT = 0.15f, Enabled = true };
		public Vector3 position
		{
			get { return _position; }
			set
			{
				// Don't do anything if the value is the same
				if (_position == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x1;
				_position = value;
				hasDirtyFields = true;
			}
		}

		public void SetpositionDirty()
		{
			_dirtyFields[0] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_position(ulong timestep)
		{
			if (positionChanged != null) positionChanged(_position, timestep);
			if (fieldAltered != null) fieldAltered("position", _position, timestep);
		}
		[ForgeGeneratedField]
		private Quaternion _rotation;
		public event FieldEvent<Quaternion> rotationChanged;
		public InterpolateQuaternion rotationInterpolation = new InterpolateQuaternion() { LerpT = 0.15f, Enabled = true };
		public Quaternion rotation
		{
			get { return _rotation; }
			set
			{
				// Don't do anything if the value is the same
				if (_rotation == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x2;
				_rotation = value;
				hasDirtyFields = true;
			}
		}

		public void SetrotationDirty()
		{
			_dirtyFields[0] |= 0x2;
			hasDirtyFields = true;
		}

		private void RunChange_rotation(ulong timestep)
		{
			if (rotationChanged != null) rotationChanged(_rotation, timestep);
			if (fieldAltered != null) fieldAltered("rotation", _rotation, timestep);
		}
		[ForgeGeneratedField]
		private Vector2 _axisDelta;
		public event FieldEvent<Vector2> axisDeltaChanged;
		public InterpolateVector2 axisDeltaInterpolation = new InterpolateVector2() { LerpT = 0.05f, Enabled = true };
		public Vector2 axisDelta
		{
			get { return _axisDelta; }
			set
			{
				// Don't do anything if the value is the same
				if (_axisDelta == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x4;
				_axisDelta = value;
				hasDirtyFields = true;
			}
		}

		public void SetaxisDeltaDirty()
		{
			_dirtyFields[0] |= 0x4;
			hasDirtyFields = true;
		}

		private void RunChange_axisDelta(ulong timestep)
		{
			if (axisDeltaChanged != null) axisDeltaChanged(_axisDelta, timestep);
			if (fieldAltered != null) fieldAltered("axisDelta", _axisDelta, timestep);
		}
		[ForgeGeneratedField]
		private float _vertVelocity;
		public event FieldEvent<float> vertVelocityChanged;
		public InterpolateFloat vertVelocityInterpolation = new InterpolateFloat() { LerpT = 0.15f, Enabled = true };
		public float vertVelocity
		{
			get { return _vertVelocity; }
			set
			{
				// Don't do anything if the value is the same
				if (_vertVelocity == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x8;
				_vertVelocity = value;
				hasDirtyFields = true;
			}
		}

		public void SetvertVelocityDirty()
		{
			_dirtyFields[0] |= 0x8;
			hasDirtyFields = true;
		}

		private void RunChange_vertVelocity(ulong timestep)
		{
			if (vertVelocityChanged != null) vertVelocityChanged(_vertVelocity, timestep);
			if (fieldAltered != null) fieldAltered("vertVelocity", _vertVelocity, timestep);
		}
		[ForgeGeneratedField]
		private bool _grounded;
		public event FieldEvent<bool> groundedChanged;
		public Interpolated<bool> groundedInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool grounded
		{
			get { return _grounded; }
			set
			{
				// Don't do anything if the value is the same
				if (_grounded == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x10;
				_grounded = value;
				hasDirtyFields = true;
			}
		}

		public void SetgroundedDirty()
		{
			_dirtyFields[0] |= 0x10;
			hasDirtyFields = true;
		}

		private void RunChange_grounded(ulong timestep)
		{
			if (groundedChanged != null) groundedChanged(_grounded, timestep);
			if (fieldAltered != null) fieldAltered("grounded", _grounded, timestep);
		}
		[ForgeGeneratedField]
		private int _weaponIndex;
		public event FieldEvent<int> weaponIndexChanged;
		public Interpolated<int> weaponIndexInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int weaponIndex
		{
			get { return _weaponIndex; }
			set
			{
				// Don't do anything if the value is the same
				if (_weaponIndex == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x20;
				_weaponIndex = value;
				hasDirtyFields = true;
			}
		}

		public void SetweaponIndexDirty()
		{
			_dirtyFields[0] |= 0x20;
			hasDirtyFields = true;
		}

		private void RunChange_weaponIndex(ulong timestep)
		{
			if (weaponIndexChanged != null) weaponIndexChanged(_weaponIndex, timestep);
			if (fieldAltered != null) fieldAltered("weaponIndex", _weaponIndex, timestep);
		}
		[ForgeGeneratedField]
		private int _skillIndex;
		public event FieldEvent<int> skillIndexChanged;
		public Interpolated<int> skillIndexInterpolation = new Interpolated<int>() { LerpT = 0f, Enabled = false };
		public int skillIndex
		{
			get { return _skillIndex; }
			set
			{
				// Don't do anything if the value is the same
				if (_skillIndex == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x40;
				_skillIndex = value;
				hasDirtyFields = true;
			}
		}

		public void SetskillIndexDirty()
		{
			_dirtyFields[0] |= 0x40;
			hasDirtyFields = true;
		}

		private void RunChange_skillIndex(ulong timestep)
		{
			if (skillIndexChanged != null) skillIndexChanged(_skillIndex, timestep);
			if (fieldAltered != null) fieldAltered("skillIndex", _skillIndex, timestep);
		}
		[ForgeGeneratedField]
		private bool _blocked;
		public event FieldEvent<bool> blockedChanged;
		public Interpolated<bool> blockedInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool blocked
		{
			get { return _blocked; }
			set
			{
				// Don't do anything if the value is the same
				if (_blocked == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x80;
				_blocked = value;
				hasDirtyFields = true;
			}
		}

		public void SetblockedDirty()
		{
			_dirtyFields[0] |= 0x80;
			hasDirtyFields = true;
		}

		private void RunChange_blocked(ulong timestep)
		{
			if (blockedChanged != null) blockedChanged(_blocked, timestep);
			if (fieldAltered != null) fieldAltered("blocked", _blocked, timestep);
		}
		[ForgeGeneratedField]
		private Vector3 _lookatDir;
		public event FieldEvent<Vector3> lookatDirChanged;
		public InterpolateVector3 lookatDirInterpolation = new InterpolateVector3() { LerpT = 0.15f, Enabled = true };
		public Vector3 lookatDir
		{
			get { return _lookatDir; }
			set
			{
				// Don't do anything if the value is the same
				if (_lookatDir == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[1] |= 0x1;
				_lookatDir = value;
				hasDirtyFields = true;
			}
		}

		public void SetlookatDirDirty()
		{
			_dirtyFields[1] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_lookatDir(ulong timestep)
		{
			if (lookatDirChanged != null) lookatDirChanged(_lookatDir, timestep);
			if (fieldAltered != null) fieldAltered("lookatDir", _lookatDir, timestep);
		}

		protected override void OwnershipChanged()
		{
			base.OwnershipChanged();
			SnapInterpolations();
		}
		
		public void SnapInterpolations()
		{
			positionInterpolation.current = positionInterpolation.target;
			rotationInterpolation.current = rotationInterpolation.target;
			axisDeltaInterpolation.current = axisDeltaInterpolation.target;
			vertVelocityInterpolation.current = vertVelocityInterpolation.target;
			groundedInterpolation.current = groundedInterpolation.target;
			weaponIndexInterpolation.current = weaponIndexInterpolation.target;
			skillIndexInterpolation.current = skillIndexInterpolation.target;
			blockedInterpolation.current = blockedInterpolation.target;
			lookatDirInterpolation.current = lookatDirInterpolation.target;
		}

		public override int UniqueIdentity { get { return IDENTITY; } }

		protected override BMSByte WritePayload(BMSByte data)
		{
			UnityObjectMapper.Instance.MapBytes(data, _position);
			UnityObjectMapper.Instance.MapBytes(data, _rotation);
			UnityObjectMapper.Instance.MapBytes(data, _axisDelta);
			UnityObjectMapper.Instance.MapBytes(data, _vertVelocity);
			UnityObjectMapper.Instance.MapBytes(data, _grounded);
			UnityObjectMapper.Instance.MapBytes(data, _weaponIndex);
			UnityObjectMapper.Instance.MapBytes(data, _skillIndex);
			UnityObjectMapper.Instance.MapBytes(data, _blocked);
			UnityObjectMapper.Instance.MapBytes(data, _lookatDir);

			return data;
		}

		protected override void ReadPayload(BMSByte payload, ulong timestep)
		{
			_position = UnityObjectMapper.Instance.Map<Vector3>(payload);
			positionInterpolation.current = _position;
			positionInterpolation.target = _position;
			RunChange_position(timestep);
			_rotation = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			rotationInterpolation.current = _rotation;
			rotationInterpolation.target = _rotation;
			RunChange_rotation(timestep);
			_axisDelta = UnityObjectMapper.Instance.Map<Vector2>(payload);
			axisDeltaInterpolation.current = _axisDelta;
			axisDeltaInterpolation.target = _axisDelta;
			RunChange_axisDelta(timestep);
			_vertVelocity = UnityObjectMapper.Instance.Map<float>(payload);
			vertVelocityInterpolation.current = _vertVelocity;
			vertVelocityInterpolation.target = _vertVelocity;
			RunChange_vertVelocity(timestep);
			_grounded = UnityObjectMapper.Instance.Map<bool>(payload);
			groundedInterpolation.current = _grounded;
			groundedInterpolation.target = _grounded;
			RunChange_grounded(timestep);
			_weaponIndex = UnityObjectMapper.Instance.Map<int>(payload);
			weaponIndexInterpolation.current = _weaponIndex;
			weaponIndexInterpolation.target = _weaponIndex;
			RunChange_weaponIndex(timestep);
			_skillIndex = UnityObjectMapper.Instance.Map<int>(payload);
			skillIndexInterpolation.current = _skillIndex;
			skillIndexInterpolation.target = _skillIndex;
			RunChange_skillIndex(timestep);
			_blocked = UnityObjectMapper.Instance.Map<bool>(payload);
			blockedInterpolation.current = _blocked;
			blockedInterpolation.target = _blocked;
			RunChange_blocked(timestep);
			_lookatDir = UnityObjectMapper.Instance.Map<Vector3>(payload);
			lookatDirInterpolation.current = _lookatDir;
			lookatDirInterpolation.target = _lookatDir;
			RunChange_lookatDir(timestep);
		}

		protected override BMSByte SerializeDirtyFields()
		{
			dirtyFieldsData.Clear();
			dirtyFieldsData.Append(_dirtyFields);

			if ((0x1 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _position);
			if ((0x2 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _rotation);
			if ((0x4 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _axisDelta);
			if ((0x8 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _vertVelocity);
			if ((0x10 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _grounded);
			if ((0x20 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _weaponIndex);
			if ((0x40 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _skillIndex);
			if ((0x80 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _blocked);
			if ((0x1 & _dirtyFields[1]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _lookatDir);

			// Reset all the dirty fields
			for (int i = 0; i < _dirtyFields.Length; i++)
				_dirtyFields[i] = 0;

			return dirtyFieldsData;
		}

		protected override void ReadDirtyFields(BMSByte data, ulong timestep)
		{
			if (readDirtyFlags == null)
				Initialize();

			Buffer.BlockCopy(data.byteArr, data.StartIndex(), readDirtyFlags, 0, readDirtyFlags.Length);
			data.MoveStartIndex(readDirtyFlags.Length);

			if ((0x1 & readDirtyFlags[0]) != 0)
			{
				if (positionInterpolation.Enabled)
				{
					positionInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					positionInterpolation.Timestep = timestep;
				}
				else
				{
					_position = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_position(timestep);
				}
			}
			if ((0x2 & readDirtyFlags[0]) != 0)
			{
				if (rotationInterpolation.Enabled)
				{
					rotationInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					rotationInterpolation.Timestep = timestep;
				}
				else
				{
					_rotation = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_rotation(timestep);
				}
			}
			if ((0x4 & readDirtyFlags[0]) != 0)
			{
				if (axisDeltaInterpolation.Enabled)
				{
					axisDeltaInterpolation.target = UnityObjectMapper.Instance.Map<Vector2>(data);
					axisDeltaInterpolation.Timestep = timestep;
				}
				else
				{
					_axisDelta = UnityObjectMapper.Instance.Map<Vector2>(data);
					RunChange_axisDelta(timestep);
				}
			}
			if ((0x8 & readDirtyFlags[0]) != 0)
			{
				if (vertVelocityInterpolation.Enabled)
				{
					vertVelocityInterpolation.target = UnityObjectMapper.Instance.Map<float>(data);
					vertVelocityInterpolation.Timestep = timestep;
				}
				else
				{
					_vertVelocity = UnityObjectMapper.Instance.Map<float>(data);
					RunChange_vertVelocity(timestep);
				}
			}
			if ((0x10 & readDirtyFlags[0]) != 0)
			{
				if (groundedInterpolation.Enabled)
				{
					groundedInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					groundedInterpolation.Timestep = timestep;
				}
				else
				{
					_grounded = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_grounded(timestep);
				}
			}
			if ((0x20 & readDirtyFlags[0]) != 0)
			{
				if (weaponIndexInterpolation.Enabled)
				{
					weaponIndexInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					weaponIndexInterpolation.Timestep = timestep;
				}
				else
				{
					_weaponIndex = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_weaponIndex(timestep);
				}
			}
			if ((0x40 & readDirtyFlags[0]) != 0)
			{
				if (skillIndexInterpolation.Enabled)
				{
					skillIndexInterpolation.target = UnityObjectMapper.Instance.Map<int>(data);
					skillIndexInterpolation.Timestep = timestep;
				}
				else
				{
					_skillIndex = UnityObjectMapper.Instance.Map<int>(data);
					RunChange_skillIndex(timestep);
				}
			}
			if ((0x80 & readDirtyFlags[0]) != 0)
			{
				if (blockedInterpolation.Enabled)
				{
					blockedInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					blockedInterpolation.Timestep = timestep;
				}
				else
				{
					_blocked = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_blocked(timestep);
				}
			}
			if ((0x1 & readDirtyFlags[1]) != 0)
			{
				if (lookatDirInterpolation.Enabled)
				{
					lookatDirInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					lookatDirInterpolation.Timestep = timestep;
				}
				else
				{
					_lookatDir = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_lookatDir(timestep);
				}
			}
		}

		public override void InterpolateUpdate()
		{
			if (IsOwner)
				return;

			if (positionInterpolation.Enabled && !positionInterpolation.current.UnityNear(positionInterpolation.target, 0.0015f))
			{
				_position = (Vector3)positionInterpolation.Interpolate();
				//RunChange_position(positionInterpolation.Timestep);
			}
			if (rotationInterpolation.Enabled && !rotationInterpolation.current.UnityNear(rotationInterpolation.target, 0.0015f))
			{
				_rotation = (Quaternion)rotationInterpolation.Interpolate();
				//RunChange_rotation(rotationInterpolation.Timestep);
			}
			if (axisDeltaInterpolation.Enabled && !axisDeltaInterpolation.current.UnityNear(axisDeltaInterpolation.target, 0.0015f))
			{
				_axisDelta = (Vector2)axisDeltaInterpolation.Interpolate();
				//RunChange_axisDelta(axisDeltaInterpolation.Timestep);
			}
			if (vertVelocityInterpolation.Enabled && !vertVelocityInterpolation.current.UnityNear(vertVelocityInterpolation.target, 0.0015f))
			{
				_vertVelocity = (float)vertVelocityInterpolation.Interpolate();
				//RunChange_vertVelocity(vertVelocityInterpolation.Timestep);
			}
			if (groundedInterpolation.Enabled && !groundedInterpolation.current.UnityNear(groundedInterpolation.target, 0.0015f))
			{
				_grounded = (bool)groundedInterpolation.Interpolate();
				//RunChange_grounded(groundedInterpolation.Timestep);
			}
			if (weaponIndexInterpolation.Enabled && !weaponIndexInterpolation.current.UnityNear(weaponIndexInterpolation.target, 0.0015f))
			{
				_weaponIndex = (int)weaponIndexInterpolation.Interpolate();
				//RunChange_weaponIndex(weaponIndexInterpolation.Timestep);
			}
			if (skillIndexInterpolation.Enabled && !skillIndexInterpolation.current.UnityNear(skillIndexInterpolation.target, 0.0015f))
			{
				_skillIndex = (int)skillIndexInterpolation.Interpolate();
				//RunChange_skillIndex(skillIndexInterpolation.Timestep);
			}
			if (blockedInterpolation.Enabled && !blockedInterpolation.current.UnityNear(blockedInterpolation.target, 0.0015f))
			{
				_blocked = (bool)blockedInterpolation.Interpolate();
				//RunChange_blocked(blockedInterpolation.Timestep);
			}
			if (lookatDirInterpolation.Enabled && !lookatDirInterpolation.current.UnityNear(lookatDirInterpolation.target, 0.0015f))
			{
				_lookatDir = (Vector3)lookatDirInterpolation.Interpolate();
				//RunChange_lookatDir(lookatDirInterpolation.Timestep);
			}
		}

		private void Initialize()
		{
			if (readDirtyFlags == null)
				readDirtyFlags = new byte[2];

		}

		public PlayerNetworkObject() : base() { Initialize(); }
		public PlayerNetworkObject(NetWorker networker, INetworkBehavior networkBehavior = null, int createCode = 0, byte[] metadata = null) : base(networker, networkBehavior, createCode, metadata) { Initialize(); }
		public PlayerNetworkObject(NetWorker networker, uint serverId, FrameStream frame) : base(networker, serverId, frame) { Initialize(); }

		// DO NOT TOUCH, THIS GETS GENERATED PLEASE EXTEND THIS CLASS IF YOU WISH TO HAVE CUSTOM CODE ADDITIONS
	}
}
