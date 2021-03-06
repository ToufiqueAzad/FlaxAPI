// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// Physics simulation driven object.
    /// </summary>
    [Serializable]
    public sealed partial class RigidBody : Actor
    {
        /// <summary>
        /// Creates new <see cref="RigidBody"/> object.
        /// </summary>
        private RigidBody() : base()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="RigidBody"/> object.
        /// </summary>
        /// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static RigidBody New()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Create(typeof(RigidBody)) as RigidBody;
#endif
        }

        /// <summary>
        /// Enables kinematic mode for the rigidbody.
        /// </summary>
        /// <remarks>
        /// Kinematic rigidbodies are special dynamic actors that are not influenced by forces(such as gravity), and have no momentum. They are considered to have infinite mass and can push regular dynamic actors out of the way.Kinematics will not collide with static or other kinematic objects.<para>Kinematic rigidbodies are great for moving platforms or characters, where direct motion control is desired.</para><para>Kinematic rigidbodies are incompatible with CCD.</para>
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(10), DefaultValue(false), EditorDisplay("Rigid Body"), Tooltip("Enables kinematic mode for the rigidbody.")]
        public bool IsKinematic
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetIsKinematic(unmanagedPtr); }
            set { Internal_SetIsKinematic(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// If true simulation and collisions detection will be enabled for the rigidbody.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(20), DefaultValue(true), EditorDisplay("Rigid Body"), Tooltip("If true simulation and collisions detection will be enabled for the rigidbody.")]
        public bool EnableSimulation
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetEnableSimulation(unmanagedPtr); }
            set { Internal_SetEnableSimulation(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// If true Continuous Collision Detection (CCD) will be used for this object.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(30), DefaultValue(false), EditorDisplay("Rigid Body", "Use CCD"), Tooltip("If true Continuous Collision Detection (CCD) will be used for this object.")]
        public bool UseCCD
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetUseCCD(unmanagedPtr); }
            set { Internal_SetUseCCD(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// If object should have the force of gravity applied.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(40), DefaultValue(true), EditorDisplay("Rigid Body"), Tooltip("If object should have the force of gravity applied.")]
        public bool EnableGravity
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetEnableGravity(unmanagedPtr); }
            set { Internal_SetEnableGravity(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// If object should start awake, or if it should initially be sleeping.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(50), DefaultValue(true), EditorDisplay("Rigid Body"), Tooltip("If object should start awake, or if it should initially be sleeping.")]
        public bool StartAwake
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetStartAwake(unmanagedPtr); }
            set { Internal_SetStartAwake(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the 'drag' force added to reduce linear movement.
        /// </summary>
        /// <remarks>
        /// Linear damping can be used to slow down an object. The higher the drag the more the object slows down.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(60), DefaultValue(0.01f), Limit(0), EditorDisplay("Rigid Body"), Tooltip("The 'drag' force added to reduce linear movement")]
        public float LinearDamping
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetLinearDamping(unmanagedPtr); }
            set { Internal_SetLinearDamping(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the 'drag' force added to reduce angular movement.
        /// </summary>
        /// <remarks>
        /// Angular damping can be used to slow down the rotation of an object. The higher the drag the more the rotation slows down.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(70), DefaultValue(0.05f), Limit(0), EditorDisplay("Rigid Body"), Tooltip("The 'drag' force added to reduce angular movement.")]
        public float AngularDamping
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetAngularDamping(unmanagedPtr); }
            set { Internal_SetAngularDamping(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the maximum angular velocity that a simulated object can achieve.
        /// </summary>
        /// <remarks>
        /// The angular velocity of rigidbodies is clamped to MaxAngularVelocity to avoid numerical instability with fast rotating bodies. Because this may prevent intentional fast rotations on objects such as wheels, you can override this value per rigidbody.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(90), DefaultValue(7.0f), Limit(0), EditorDisplay("Rigid Body"), Tooltip("The maximum angular velocity that a simulated object can achieve.")]
        public float MaxAngularVelocity
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMaxAngularVelocity(unmanagedPtr); }
            set { Internal_SetMaxAngularVelocity(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Override the auto computed mass.
        /// </summary>
        [UnmanagedCall]
        [HideInEditor]
        public bool OverrideMass
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetOverrideMass(unmanagedPtr); }
            set { Internal_SetOverrideMass(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the mass value measured in kilograms (use override value only if EnableOverrideMass is enabled).
        /// </summary>
        /// <remarks>
        /// The object mass value is computed from the density and attached colliders (taking into account other parameters like MassScale). Use may override it by enabling OverrideMass and providing a custom value. Setting this property automatically overrides the calculated value.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(110), Limit(0), EditorDisplay("Rigid Body"), Tooltip("The mass value measured in kilograms (use override value only if OverrideMass is enabled).")]
        public float Mass
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMass(unmanagedPtr); }
            set { Internal_SetMass(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the per-instance scaling of the mass.
        /// </summary>
        /// <remarks>
        /// Used only for auto computed mass, not the overriden value.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(120), DefaultValue(1.0f), Limit(0.001f, 100.0f), EditorDisplay("Rigid Body"), Tooltip("The per-instance scaling of the mass (only for auto computed mass).")]
        public float MassScale
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMassScale(unmanagedPtr); }
            set { Internal_SetMassScale(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// If true, it will update mass when actor scale changes.
        /// </summary>
        /// <remarks>
        /// Used only when mass is not being overriden.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(130), DefaultValue(false), EditorDisplay("Rigid Body"), Tooltip("If true, it will update mass when actor scale changes.")]
        public bool UpdateMassWhenScaleChanges
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetUpdateMassWhenScaleChanges(unmanagedPtr); }
            set { Internal_SetUpdateMassWhenScaleChanges(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the user specified offset for the center of mass of this object, from the calculated location.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(140), DefaultValue(typeof(Vector3), "0,0,0"), EditorDisplay("Rigid Body", "Center Of Mass Offset"), Tooltip("The user specified offset for the center of mass of this object, from the calculated location.")]
        public Vector3 CenterOfMassOffset
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Vector3 resultAsRef; Internal_GetCenterOfMassOffset(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetCenterOfMassOffset(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the object movement constraint flags that define degrees of freedom are allowed for the simulation of object.
        /// </summary>
        [UnmanagedCall]
        [EditorOrder(150), DefaultValue(RigidbodyConstraints.None), EditorDisplay("Rigid Body"), Tooltip("The object movement constraint flags that define degrees of freedom are allowed for the simulation of object.")]
        public RigidbodyConstraints Constraints
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetConstraints(unmanagedPtr); }
            set { Internal_SetConstraints(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the linear velocity of the rigidbody.
        /// </summary>
        /// <remarks>
        /// It's used mostly to get the current velocity. Manual modifications may result in unrealistic behaviour.
        /// </remarks>
        [UnmanagedCall]
        [HideInEditor]
        public Vector3 LinearVelocity
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Vector3 resultAsRef; Internal_GetLinearVelocity(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetLinearVelocity(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the angular velocity of the rigidbody measured in radians per second.
        /// </summary>
        /// <remarks>
        /// It's used mostly to get the current angular velocity. Manual modifications may result in unrealistic behaviour.
        /// </remarks>
        [UnmanagedCall]
        [HideInEditor]
        public Vector3 AngularVelocity
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Vector3 resultAsRef; Internal_GetAngularVelocity(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetAngularVelocity(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Gets or sets the maximum depenetration velocity when rigidbody moving out of penetrating state.
        /// </summary>
        /// <remarks>
        /// This value controls how much velocity the solver can introduce to correct for penetrations in contacts. Using this property can smooth objects moving out of colliding state and prevent unstable motion.
        /// </remarks>
        [UnmanagedCall]
        [HideInEditor]
        public float MaxDepenetrationVelocity
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMaxDepenetrationVelocity(unmanagedPtr); }
            set { Internal_SetMaxDepenetrationVelocity(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the mass-normalized kinetic energy threshold below which an actor may go to sleep.
        /// </summary>
        /// <remarks>
        /// Actors whose kinetic energy divided by their mass is below this threshold will be candidates for sleeping.
        /// </remarks>
        [UnmanagedCall]
        [HideInEditor]
        public float SleepThreshold
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetSleepThreshold(unmanagedPtr); }
            set { Internal_SetSleepThreshold(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the center of the mass in the local space.
        /// </summary>
        [UnmanagedCall]
        public Vector3 CenterOfMass
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Vector3 resultAsRef; Internal_GetCenterOfMass(unmanagedPtr, out resultAsRef); return resultAsRef; }
#endif
        }

        /// <summary>
        /// Determines whether this rigidbody is sleeping.
        /// </summary>
        /// <remarks>
        /// When an actor does not move for a period of time, it is no longer simulated in order to save time. This state is called sleeping. However, because the object automatically wakes up when it is either touched by an awake object, or one of its properties is changed by the user, the entire sleep mechanism should be transparent to the user.
        /// </remarks>
        [UnmanagedCall]
        public bool IsSleeping
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetIsSleeping(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Forces a rigidbody to sleep (for at least one frame).
        /// </summary>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void Sleep()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_Sleep(unmanagedPtr);
#endif
        }

        /// <summary>
        /// Forces a rigidbody to wake up.
        /// </summary>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void WakeUp()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_WakeUp(unmanagedPtr);
#endif
        }

        /// <summary>
        /// Applies a force (or impulse) defined in the world space to the rigidbody at its center of mass.
        /// </summary>
        /// <remarks>
        /// This will not induce a torque<para>ForceMode determines if the force is to be conventional or impulsive.</para><para>Each actor has an acceleration and a velocity change accumulator which are directly modified using the modes ForceMode.Acceleration and ForceMode.VelocityChange respectively. The modes ForceMode.Force and ForceMode.Impulse also modify these same accumulators and are just short hand for multiplying the vector parameter by inverse mass and then using ForceMode.Acceleration and ForceMode.VelocityChange respectively.</para>
        /// </remarks>
        /// <param name="force">The force/impulse to apply defined in the world space.</param>
        /// <param name="mode">The mode to use when applying the force/impulse.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_AddForce(unmanagedPtr, ref force, mode);
#endif
        }

        /// <summary>
        /// Applies a force (or impulse) defined in the local space of the rigidbody (relative to its coordinate system) at its center of mass.
        /// </summary>
        /// <remarks>
        /// This will not induce a torque<para>ForceMode determines if the force is to be conventional or impulsive.</para><para>Each actor has an acceleration and a velocity change accumulator which are directly modified using the modes ForceMode.Acceleration and ForceMode.VelocityChange respectively. The modes ForceMode.Force and ForceMode.Impulse also modify these same accumulators and are just short hand for multiplying the vector parameter by inverse mass and then using ForceMode.Acceleration and ForceMode.VelocityChange respectively.</para>
        /// </remarks>
        /// <param name="force">The force/impulse to apply defined in the local space.</param>
        /// <param name="mode">The mode to use when applying the force/impulse.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void AddRelativeForce(Vector3 force, ForceMode mode = ForceMode.Force)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_AddRelativeForce(unmanagedPtr, ref force, mode);
#endif
        }

        /// <summary>
        /// Applies an impulsive torque defined in the world space to the rigidbody.
        /// </summary>
        /// <remarks>
        /// ForceMode determines if the force is to be conventional or impulsive.<para>Each actor has an angular acceleration and an angular velocity change accumulator which are directly modified using the modes ForceMode.Acceleration and ForceMode.VelocityChange respectively.The modes ForceMode.Force and ForceMode.Impulse also modify these same accumulators and are just short hand for multiplying the vector parameter by inverse inertia and then using ForceMode.Acceleration and ForceMode.VelocityChange respectively.</para>
        /// </remarks>
        /// <param name="torque">The torque to apply defined in the world space.</param>
        /// <param name="mode">The mode to use when applying the force/impulse.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_AddTorque(unmanagedPtr, ref torque, mode);
#endif
        }

        /// <summary>
        /// Applies an impulsive torque defined in the local space of the rigidbody (relative to its coordinate system).
        /// </summary>
        /// <remarks>
        /// ForceMode determines if the force is to be conventional or impulsive.<para>Each actor has an angular acceleration and an angular velocity change accumulator which are directly modified using the modes ForceMode.Acceleration and ForceMode.VelocityChange respectively.The modes ForceMode.Force and ForceMode.Impulse also modify these same accumulators and are just short hand for multiplying the vector parameter by inverse inertia and then using ForceMode.Acceleration and ForceMode.VelocityChange respectively.</para>
        /// </remarks>
        /// <param name="torque">The torque to apply defined in the local space.</param>
        /// <param name="mode">The mode to use when applying the force/impulse.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void AddRelativeTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_AddRelativeTorque(unmanagedPtr, ref torque, mode);
#endif
        }

        /// <summary>
        /// Sets the solver iteration counts for the rigidbody.
        /// </summary>
        /// <remarks>
        /// The solver iteration count determines how accurately joints and contacts are resolved. If you are having trouble with jointed bodies oscillating and behaving erratically, then setting a higher position iteration count may improve their stability.<para>If intersecting bodies are being depenetrated too violently, increase the number of velocity  iterations. More velocity iterations will drive the relative exit velocity of the intersecting objects closer to the correct value given the restitution.</para><para>Default: 4 position iterations, 1 velocity iteration.</para>
        /// </remarks>
        /// <param name="minPositionIters">The minimum number of position iterations the solver should perform for this body.</param>
        /// <param name="minVelocityIters">The minimum number of velocity iterations the solver should perform for this body.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void SetSolverIterationCounts(int minPositionIters, int minVelocityIters = 1)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_SetSolverIterationCounts(unmanagedPtr, minPositionIters, minVelocityIters);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetIsKinematic(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetIsKinematic(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetEnableSimulation(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetEnableSimulation(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetUseCCD(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetUseCCD(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetEnableGravity(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetEnableGravity(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetStartAwake(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetStartAwake(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetLinearDamping(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetLinearDamping(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetAngularDamping(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetAngularDamping(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetMaxAngularVelocity(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetMaxAngularVelocity(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetOverrideMass(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetOverrideMass(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetMass(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetMass(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetMassScale(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetMassScale(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetUpdateMassWhenScaleChanges(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetUpdateMassWhenScaleChanges(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetCenterOfMassOffset(IntPtr obj, out Vector3 resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetCenterOfMassOffset(IntPtr obj, ref Vector3 val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern RigidbodyConstraints Internal_GetConstraints(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetConstraints(IntPtr obj, RigidbodyConstraints val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetLinearVelocity(IntPtr obj, out Vector3 resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetLinearVelocity(IntPtr obj, ref Vector3 val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetAngularVelocity(IntPtr obj, out Vector3 resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetAngularVelocity(IntPtr obj, ref Vector3 val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetMaxDepenetrationVelocity(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetMaxDepenetrationVelocity(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetSleepThreshold(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetSleepThreshold(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetCenterOfMass(IntPtr obj, out Vector3 resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetIsSleeping(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_Sleep(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_WakeUp(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_AddForce(IntPtr obj, ref Vector3 force, ForceMode mode);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_AddRelativeForce(IntPtr obj, ref Vector3 force, ForceMode mode);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_AddTorque(IntPtr obj, ref Vector3 torque, ForceMode mode);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_AddRelativeTorque(IntPtr obj, ref Vector3 torque, ForceMode mode);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetSolverIterationCounts(IntPtr obj, int minPositionIters, int minVelocityIters);
#endif

        #endregion
    }
}
