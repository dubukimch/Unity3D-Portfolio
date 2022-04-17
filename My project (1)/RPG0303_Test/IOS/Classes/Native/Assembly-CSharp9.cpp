#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


struct VirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct VirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
struct GenericVirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
struct GenericInterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Collections.Generic.Dictionary`2<System.Enum,System.Collections.Generic.Dictionary`2<System.String,System.Delegate>>
struct Dictionary_2_tDE192EFC3F4EFFED7FE11B34697861F229089C8F;
// System.Collections.Generic.Dictionary`2<System.String,RPGCharacterAnims.Actions.IActionHandler>
struct Dictionary_2_t681FAD08BD8140C644F9A6270F3711539ED446AE;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// System.Action
struct Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6;
// UnityEngine.Animator
struct Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// RPGCharacterAnims.CoroutineQueue
struct CoroutineQueue_t68E1D1488507A988985DC27398A47D67AE2B1CF1;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA;
// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// RPGCharacterAnims.IKHands
struct IKHands_t2CD8186746290A10D977BE5B0CA9ED44513627BB;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// RPGCharacterAnims.RPGCharacterController
struct RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19;
// RPGCharacterAnims.RPGCharacterWeaponController
struct RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7;
// System.String
struct String_t;
// RPGCharacterAnims.Actions.SwitchWeapon
struct SwitchWeapon_tFC5CDE1644522BF7B2F853721E41C9548F244226;
// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// SuperCharacterController/UpdateDelegate
struct UpdateDelegate_t61C37A9FBEC6671FAF75E6914BF252417C0D9F4F;
// SuperStateMachine/State
struct State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD;
// RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0
struct U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42;
// SuperCharacterController/SuperGround/GroundHit
struct GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA;

IL2CPP_EXTERN_C RuntimeClass* Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C const RuntimeMethod* SuperStateMachine_DoNothing_m203B2026577A03CF9EA025EAE48DD692639629FA_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;

struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// RPGCharacterAnims.Actions.BaseActionHandler`1<RPGCharacterAnims.Actions.SwitchWeaponContext>
struct BaseActionHandler_1_t048F4EA8E5F836FF2B18CDE215EFC710D32C407E  : public RuntimeObject
{
public:
	// System.Boolean RPGCharacterAnims.Actions.BaseActionHandler`1::active
	bool ___active_0;
	// System.Action RPGCharacterAnims.Actions.BaseActionHandler`1::OnStart
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___OnStart_1;
	// System.Action RPGCharacterAnims.Actions.BaseActionHandler`1::OnEnd
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___OnEnd_2;

public:
	inline static int32_t get_offset_of_active_0() { return static_cast<int32_t>(offsetof(BaseActionHandler_1_t048F4EA8E5F836FF2B18CDE215EFC710D32C407E, ___active_0)); }
	inline bool get_active_0() const { return ___active_0; }
	inline bool* get_address_of_active_0() { return &___active_0; }
	inline void set_active_0(bool value)
	{
		___active_0 = value;
	}

	inline static int32_t get_offset_of_OnStart_1() { return static_cast<int32_t>(offsetof(BaseActionHandler_1_t048F4EA8E5F836FF2B18CDE215EFC710D32C407E, ___OnStart_1)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_OnStart_1() const { return ___OnStart_1; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_OnStart_1() { return &___OnStart_1; }
	inline void set_OnStart_1(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___OnStart_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___OnStart_1), (void*)value);
	}

	inline static int32_t get_offset_of_OnEnd_2() { return static_cast<int32_t>(offsetof(BaseActionHandler_1_t048F4EA8E5F836FF2B18CDE215EFC710D32C407E, ___OnEnd_2)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_OnEnd_2() const { return ___OnEnd_2; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_OnEnd_2() { return &___OnEnd_2; }
	inline void set_OnEnd_2(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___OnEnd_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___OnEnd_2), (void*)value);
	}
};

struct Il2CppArrayBounds;

// System.Array


// System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_com
{
};

// SuperStateMachine/State
struct State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD  : public RuntimeObject
{
public:
	// System.Action SuperStateMachine/State::DoSuperUpdate
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___DoSuperUpdate_0;
	// System.Action SuperStateMachine/State::enterState
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___enterState_1;
	// System.Action SuperStateMachine/State::exitState
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___exitState_2;
	// System.Enum SuperStateMachine/State::currentState
	Enum_t23B90B40F60E677A8025267341651C94AE079CDA * ___currentState_3;

public:
	inline static int32_t get_offset_of_DoSuperUpdate_0() { return static_cast<int32_t>(offsetof(State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD, ___DoSuperUpdate_0)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_DoSuperUpdate_0() const { return ___DoSuperUpdate_0; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_DoSuperUpdate_0() { return &___DoSuperUpdate_0; }
	inline void set_DoSuperUpdate_0(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___DoSuperUpdate_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___DoSuperUpdate_0), (void*)value);
	}

	inline static int32_t get_offset_of_enterState_1() { return static_cast<int32_t>(offsetof(State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD, ___enterState_1)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_enterState_1() const { return ___enterState_1; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_enterState_1() { return &___enterState_1; }
	inline void set_enterState_1(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___enterState_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enterState_1), (void*)value);
	}

	inline static int32_t get_offset_of_exitState_2() { return static_cast<int32_t>(offsetof(State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD, ___exitState_2)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_exitState_2() const { return ___exitState_2; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_exitState_2() { return &___exitState_2; }
	inline void set_exitState_2(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___exitState_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___exitState_2), (void*)value);
	}

	inline static int32_t get_offset_of_currentState_3() { return static_cast<int32_t>(offsetof(State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD, ___currentState_3)); }
	inline Enum_t23B90B40F60E677A8025267341651C94AE079CDA * get_currentState_3() const { return ___currentState_3; }
	inline Enum_t23B90B40F60E677A8025267341651C94AE079CDA ** get_address_of_currentState_3() { return &___currentState_3; }
	inline void set_currentState_3(Enum_t23B90B40F60E677A8025267341651C94AE079CDA * value)
	{
		___currentState_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currentState_3), (void*)value);
	}
};


// System.Boolean
struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA  : public ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52
{
public:

public:
};

struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_com
{
};

// System.IntPtr
struct IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// System.Single
struct Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E, ___m_value_0)); }
	inline float get_m_value_0() const { return ___m_value_0; }
	inline float* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(float value)
	{
		___m_value_0 = value;
	}
};


// RPGCharacterAnims.Actions.SwitchWeapon
struct SwitchWeapon_tFC5CDE1644522BF7B2F853721E41C9548F244226  : public BaseActionHandler_1_t048F4EA8E5F836FF2B18CDE215EFC710D32C407E
{
public:

public:
};


// UnityEngine.Vector3
struct Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E 
{
public:
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;

public:
	inline static int32_t get_offset_of_x_2() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___x_2)); }
	inline float get_x_2() const { return ___x_2; }
	inline float* get_address_of_x_2() { return &___x_2; }
	inline void set_x_2(float value)
	{
		___x_2 = value;
	}

	inline static int32_t get_offset_of_y_3() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___y_3)); }
	inline float get_y_3() const { return ___y_3; }
	inline float* get_address_of_y_3() { return &___y_3; }
	inline void set_y_3(float value)
	{
		___y_3 = value;
	}

	inline static int32_t get_offset_of_z_4() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___z_4)); }
	inline float get_z_4() const { return ___z_4; }
	inline float* get_address_of_z_4() { return &___z_4; }
	inline void set_z_4(float value)
	{
		___z_4 = value;
	}
};

struct Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields
{
public:
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___negativeInfinityVector_14;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___zeroVector_5)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___oneVector_6)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_upVector_7() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___upVector_7)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_upVector_7() const { return ___upVector_7; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_upVector_7() { return &___upVector_7; }
	inline void set_upVector_7(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___upVector_7 = value;
	}

	inline static int32_t get_offset_of_downVector_8() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___downVector_8)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_downVector_8() const { return ___downVector_8; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_downVector_8() { return &___downVector_8; }
	inline void set_downVector_8(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___downVector_8 = value;
	}

	inline static int32_t get_offset_of_leftVector_9() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___leftVector_9)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_leftVector_9() const { return ___leftVector_9; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_leftVector_9() { return &___leftVector_9; }
	inline void set_leftVector_9(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___leftVector_9 = value;
	}

	inline static int32_t get_offset_of_rightVector_10() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___rightVector_10)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_rightVector_10() const { return ___rightVector_10; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_rightVector_10() { return &___rightVector_10; }
	inline void set_rightVector_10(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___rightVector_10 = value;
	}

	inline static int32_t get_offset_of_forwardVector_11() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___forwardVector_11)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_forwardVector_11() const { return ___forwardVector_11; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_forwardVector_11() { return &___forwardVector_11; }
	inline void set_forwardVector_11(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___forwardVector_11 = value;
	}

	inline static int32_t get_offset_of_backVector_12() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___backVector_12)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_backVector_12() const { return ___backVector_12; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_backVector_12() { return &___backVector_12; }
	inline void set_backVector_12(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___backVector_12 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_13() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___positiveInfinityVector_13)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_positiveInfinityVector_13() const { return ___positiveInfinityVector_13; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_positiveInfinityVector_13() { return &___positiveInfinityVector_13; }
	inline void set_positiveInfinityVector_13(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___positiveInfinityVector_13 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_14() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___negativeInfinityVector_14)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_negativeInfinityVector_14() const { return ___negativeInfinityVector_14; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_negativeInfinityVector_14() { return &___negativeInfinityVector_14; }
	inline void set_negativeInfinityVector_14(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___negativeInfinityVector_14 = value;
	}
};


// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5__padding[1];
	};

public:
};


// System.Delegate
struct Delegate_t  : public RuntimeObject
{
public:
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject * ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t * ___method_info_7;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t * ___original_method_info_8;
	// System.DelegateData System.Delegate::data
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_10;

public:
	inline static int32_t get_offset_of_method_ptr_0() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_ptr_0)); }
	inline Il2CppMethodPointer get_method_ptr_0() const { return ___method_ptr_0; }
	inline Il2CppMethodPointer* get_address_of_method_ptr_0() { return &___method_ptr_0; }
	inline void set_method_ptr_0(Il2CppMethodPointer value)
	{
		___method_ptr_0 = value;
	}

	inline static int32_t get_offset_of_invoke_impl_1() { return static_cast<int32_t>(offsetof(Delegate_t, ___invoke_impl_1)); }
	inline intptr_t get_invoke_impl_1() const { return ___invoke_impl_1; }
	inline intptr_t* get_address_of_invoke_impl_1() { return &___invoke_impl_1; }
	inline void set_invoke_impl_1(intptr_t value)
	{
		___invoke_impl_1 = value;
	}

	inline static int32_t get_offset_of_m_target_2() { return static_cast<int32_t>(offsetof(Delegate_t, ___m_target_2)); }
	inline RuntimeObject * get_m_target_2() const { return ___m_target_2; }
	inline RuntimeObject ** get_address_of_m_target_2() { return &___m_target_2; }
	inline void set_m_target_2(RuntimeObject * value)
	{
		___m_target_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_target_2), (void*)value);
	}

	inline static int32_t get_offset_of_method_3() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_3)); }
	inline intptr_t get_method_3() const { return ___method_3; }
	inline intptr_t* get_address_of_method_3() { return &___method_3; }
	inline void set_method_3(intptr_t value)
	{
		___method_3 = value;
	}

	inline static int32_t get_offset_of_delegate_trampoline_4() { return static_cast<int32_t>(offsetof(Delegate_t, ___delegate_trampoline_4)); }
	inline intptr_t get_delegate_trampoline_4() const { return ___delegate_trampoline_4; }
	inline intptr_t* get_address_of_delegate_trampoline_4() { return &___delegate_trampoline_4; }
	inline void set_delegate_trampoline_4(intptr_t value)
	{
		___delegate_trampoline_4 = value;
	}

	inline static int32_t get_offset_of_extra_arg_5() { return static_cast<int32_t>(offsetof(Delegate_t, ___extra_arg_5)); }
	inline intptr_t get_extra_arg_5() const { return ___extra_arg_5; }
	inline intptr_t* get_address_of_extra_arg_5() { return &___extra_arg_5; }
	inline void set_extra_arg_5(intptr_t value)
	{
		___extra_arg_5 = value;
	}

	inline static int32_t get_offset_of_method_code_6() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_code_6)); }
	inline intptr_t get_method_code_6() const { return ___method_code_6; }
	inline intptr_t* get_address_of_method_code_6() { return &___method_code_6; }
	inline void set_method_code_6(intptr_t value)
	{
		___method_code_6 = value;
	}

	inline static int32_t get_offset_of_method_info_7() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_info_7)); }
	inline MethodInfo_t * get_method_info_7() const { return ___method_info_7; }
	inline MethodInfo_t ** get_address_of_method_info_7() { return &___method_info_7; }
	inline void set_method_info_7(MethodInfo_t * value)
	{
		___method_info_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_info_7), (void*)value);
	}

	inline static int32_t get_offset_of_original_method_info_8() { return static_cast<int32_t>(offsetof(Delegate_t, ___original_method_info_8)); }
	inline MethodInfo_t * get_original_method_info_8() const { return ___original_method_info_8; }
	inline MethodInfo_t ** get_address_of_original_method_info_8() { return &___original_method_info_8; }
	inline void set_original_method_info_8(MethodInfo_t * value)
	{
		___original_method_info_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___original_method_info_8), (void*)value);
	}

	inline static int32_t get_offset_of_data_9() { return static_cast<int32_t>(offsetof(Delegate_t, ___data_9)); }
	inline DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * get_data_9() const { return ___data_9; }
	inline DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 ** get_address_of_data_9() { return &___data_9; }
	inline void set_data_9(DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * value)
	{
		___data_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___data_9), (void*)value);
	}

	inline static int32_t get_offset_of_method_is_virtual_10() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_is_virtual_10)); }
	inline bool get_method_is_virtual_10() const { return ___method_is_virtual_10; }
	inline bool* get_address_of_method_is_virtual_10() { return &___method_is_virtual_10; }
	inline void set_method_is_virtual_10(bool value)
	{
		___method_is_virtual_10 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	int32_t ___method_is_virtual_10;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	int32_t ___method_is_virtual_10;
};

// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// RPGCharacterAnims.Lookups.Weapon
struct Weapon_t74B50A856B3D9628CF05D40B6A9C62B55BE90240 
{
public:
	// System.Int32 RPGCharacterAnims.Lookups.Weapon::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Weapon_t74B50A856B3D9628CF05D40B6A9C62B55BE90240, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UIManager/ViewState
struct ViewState_t15884E7DFC59C2C8A66BCE8DF6C3516A9F552280 
{
public:
	// System.Int32 UIManager/ViewState::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ViewState_t15884E7DFC59C2C8A66BCE8DF6C3516A9F552280, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// SuperCharacterController/SuperGround/GroundHit
struct GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA  : public RuntimeObject
{
public:
	// UnityEngine.Vector3 SuperCharacterController/SuperGround/GroundHit::<point>k__BackingField
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___U3CpointU3Ek__BackingField_0;
	// UnityEngine.Vector3 SuperCharacterController/SuperGround/GroundHit::<normal>k__BackingField
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___U3CnormalU3Ek__BackingField_1;
	// System.Single SuperCharacterController/SuperGround/GroundHit::<distance>k__BackingField
	float ___U3CdistanceU3Ek__BackingField_2;

public:
	inline static int32_t get_offset_of_U3CpointU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA, ___U3CpointU3Ek__BackingField_0)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_U3CpointU3Ek__BackingField_0() const { return ___U3CpointU3Ek__BackingField_0; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_U3CpointU3Ek__BackingField_0() { return &___U3CpointU3Ek__BackingField_0; }
	inline void set_U3CpointU3Ek__BackingField_0(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___U3CpointU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_U3CnormalU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA, ___U3CnormalU3Ek__BackingField_1)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_U3CnormalU3Ek__BackingField_1() const { return ___U3CnormalU3Ek__BackingField_1; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_U3CnormalU3Ek__BackingField_1() { return &___U3CnormalU3Ek__BackingField_1; }
	inline void set_U3CnormalU3Ek__BackingField_1(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___U3CnormalU3Ek__BackingField_1 = value;
	}

	inline static int32_t get_offset_of_U3CdistanceU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA, ___U3CdistanceU3Ek__BackingField_2)); }
	inline float get_U3CdistanceU3Ek__BackingField_2() const { return ___U3CdistanceU3Ek__BackingField_2; }
	inline float* get_address_of_U3CdistanceU3Ek__BackingField_2() { return &___U3CdistanceU3Ek__BackingField_2; }
	inline void set_U3CdistanceU3Ek__BackingField_2(float value)
	{
		___U3CdistanceU3Ek__BackingField_2 = value;
	}
};


// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
public:
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* ___delegates_11;

public:
	inline static int32_t get_offset_of_delegates_11() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___delegates_11)); }
	inline DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* get_delegates_11() const { return ___delegates_11; }
	inline DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8** get_address_of_delegates_11() { return &___delegates_11; }
	inline void set_delegates_11(DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* value)
	{
		___delegates_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delegates_11), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_11;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_11;
};

// RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0
struct U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42  : public RuntimeObject
{
public:
	// System.Boolean RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0::changeLeft
	bool ___changeLeft_0;
	// RPGCharacterAnims.RPGCharacterController RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0::controller
	RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 * ___controller_1;
	// RPGCharacterAnims.Lookups.Weapon RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0::toLeftWeapon
	int32_t ___toLeftWeapon_2;
	// System.Boolean RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0::changeRight
	bool ___changeRight_3;
	// RPGCharacterAnims.Lookups.Weapon RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0::toRightWeapon
	int32_t ___toRightWeapon_4;
	// RPGCharacterAnims.RPGCharacterWeaponController RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0::weaponController
	RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7 * ___weaponController_5;
	// RPGCharacterAnims.Actions.SwitchWeapon RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0::<>4__this
	SwitchWeapon_tFC5CDE1644522BF7B2F853721E41C9548F244226 * ___U3CU3E4__this_6;

public:
	inline static int32_t get_offset_of_changeLeft_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42, ___changeLeft_0)); }
	inline bool get_changeLeft_0() const { return ___changeLeft_0; }
	inline bool* get_address_of_changeLeft_0() { return &___changeLeft_0; }
	inline void set_changeLeft_0(bool value)
	{
		___changeLeft_0 = value;
	}

	inline static int32_t get_offset_of_controller_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42, ___controller_1)); }
	inline RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 * get_controller_1() const { return ___controller_1; }
	inline RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 ** get_address_of_controller_1() { return &___controller_1; }
	inline void set_controller_1(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 * value)
	{
		___controller_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___controller_1), (void*)value);
	}

	inline static int32_t get_offset_of_toLeftWeapon_2() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42, ___toLeftWeapon_2)); }
	inline int32_t get_toLeftWeapon_2() const { return ___toLeftWeapon_2; }
	inline int32_t* get_address_of_toLeftWeapon_2() { return &___toLeftWeapon_2; }
	inline void set_toLeftWeapon_2(int32_t value)
	{
		___toLeftWeapon_2 = value;
	}

	inline static int32_t get_offset_of_changeRight_3() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42, ___changeRight_3)); }
	inline bool get_changeRight_3() const { return ___changeRight_3; }
	inline bool* get_address_of_changeRight_3() { return &___changeRight_3; }
	inline void set_changeRight_3(bool value)
	{
		___changeRight_3 = value;
	}

	inline static int32_t get_offset_of_toRightWeapon_4() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42, ___toRightWeapon_4)); }
	inline int32_t get_toRightWeapon_4() const { return ___toRightWeapon_4; }
	inline int32_t* get_address_of_toRightWeapon_4() { return &___toRightWeapon_4; }
	inline void set_toRightWeapon_4(int32_t value)
	{
		___toRightWeapon_4 = value;
	}

	inline static int32_t get_offset_of_weaponController_5() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42, ___weaponController_5)); }
	inline RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7 * get_weaponController_5() const { return ___weaponController_5; }
	inline RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7 ** get_address_of_weaponController_5() { return &___weaponController_5; }
	inline void set_weaponController_5(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7 * value)
	{
		___weaponController_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___weaponController_5), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3E4__this_6() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42, ___U3CU3E4__this_6)); }
	inline SwitchWeapon_tFC5CDE1644522BF7B2F853721E41C9548F244226 * get_U3CU3E4__this_6() const { return ___U3CU3E4__this_6; }
	inline SwitchWeapon_tFC5CDE1644522BF7B2F853721E41C9548F244226 ** get_address_of_U3CU3E4__this_6() { return &___U3CU3E4__this_6; }
	inline void set_U3CU3E4__this_6(SwitchWeapon_tFC5CDE1644522BF7B2F853721E41C9548F244226 * value)
	{
		___U3CU3E4__this_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_6), (void*)value);
	}
};


// System.Action
struct Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6  : public MulticastDelegate_t
{
public:

public:
};


// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Behaviour
struct Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// SuperCharacterController/UpdateDelegate
struct UpdateDelegate_t61C37A9FBEC6671FAF75E6914BF252417C0D9F4F  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.MonoBehaviour
struct MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:

public:
};


// RPGCharacterAnims.RPGCharacterController
struct RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Action RPGCharacterAnims.RPGCharacterController::OnLockActions
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___OnLockActions_4;
	// System.Action RPGCharacterAnims.RPGCharacterController::OnUnlockActions
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___OnUnlockActions_5;
	// System.Action RPGCharacterAnims.RPGCharacterController::OnLockMovement
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___OnLockMovement_6;
	// System.Action RPGCharacterAnims.RPGCharacterController::OnUnlockMovement
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___OnUnlockMovement_7;
	// UnityEngine.Animator RPGCharacterAnims.RPGCharacterController::animator
	Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator_8;
	// System.Single RPGCharacterAnims.RPGCharacterController::animationSpeed
	float ___animationSpeed_9;
	// RPGCharacterAnims.IKHands RPGCharacterAnims.RPGCharacterController::ikHands
	IKHands_t2CD8186746290A10D977BE5B0CA9ED44513627BB * ___ikHands_10;
	// UnityEngine.Transform RPGCharacterAnims.RPGCharacterController::target
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___target_11;
	// System.Boolean RPGCharacterAnims.RPGCharacterController::_canAction
	bool ____canAction_12;
	// System.Boolean RPGCharacterAnims.RPGCharacterController::_canFace
	bool ____canFace_13;
	// System.Boolean RPGCharacterAnims.RPGCharacterController::_canMove
	bool ____canMove_14;
	// System.Boolean RPGCharacterAnims.RPGCharacterController::_canStrafe
	bool ____canStrafe_15;
	// System.Boolean RPGCharacterAnims.RPGCharacterController::_isAttacking
	bool ____isAttacking_16;
	// UnityEngine.Vector3 RPGCharacterAnims.RPGCharacterController::_moveInput
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ____moveInput_17;
	// UnityEngine.Vector3 RPGCharacterAnims.RPGCharacterController::_aimInput
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ____aimInput_18;
	// UnityEngine.Vector3 RPGCharacterAnims.RPGCharacterController::_faceInput
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ____faceInput_19;
	// UnityEngine.Vector3 RPGCharacterAnims.RPGCharacterController::_jumpInput
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ____jumpInput_20;
	// UnityEngine.Vector3 RPGCharacterAnims.RPGCharacterController::_cameraRelativeInput
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ____cameraRelativeInput_21;
	// RPGCharacterAnims.Lookups.Weapon RPGCharacterAnims.RPGCharacterController::rightWeapon
	int32_t ___rightWeapon_22;
	// RPGCharacterAnims.Lookups.Weapon RPGCharacterAnims.RPGCharacterController::leftWeapon
	int32_t ___leftWeapon_23;
	// System.Collections.Generic.Dictionary`2<System.String,RPGCharacterAnims.Actions.IActionHandler> RPGCharacterAnims.RPGCharacterController::actionHandlers
	Dictionary_2_t681FAD08BD8140C644F9A6270F3711539ED446AE * ___actionHandlers_24;

public:
	inline static int32_t get_offset_of_OnLockActions_4() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___OnLockActions_4)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_OnLockActions_4() const { return ___OnLockActions_4; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_OnLockActions_4() { return &___OnLockActions_4; }
	inline void set_OnLockActions_4(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___OnLockActions_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___OnLockActions_4), (void*)value);
	}

	inline static int32_t get_offset_of_OnUnlockActions_5() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___OnUnlockActions_5)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_OnUnlockActions_5() const { return ___OnUnlockActions_5; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_OnUnlockActions_5() { return &___OnUnlockActions_5; }
	inline void set_OnUnlockActions_5(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___OnUnlockActions_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___OnUnlockActions_5), (void*)value);
	}

	inline static int32_t get_offset_of_OnLockMovement_6() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___OnLockMovement_6)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_OnLockMovement_6() const { return ___OnLockMovement_6; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_OnLockMovement_6() { return &___OnLockMovement_6; }
	inline void set_OnLockMovement_6(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___OnLockMovement_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___OnLockMovement_6), (void*)value);
	}

	inline static int32_t get_offset_of_OnUnlockMovement_7() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___OnUnlockMovement_7)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_OnUnlockMovement_7() const { return ___OnUnlockMovement_7; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_OnUnlockMovement_7() { return &___OnUnlockMovement_7; }
	inline void set_OnUnlockMovement_7(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___OnUnlockMovement_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___OnUnlockMovement_7), (void*)value);
	}

	inline static int32_t get_offset_of_animator_8() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___animator_8)); }
	inline Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * get_animator_8() const { return ___animator_8; }
	inline Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 ** get_address_of_animator_8() { return &___animator_8; }
	inline void set_animator_8(Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * value)
	{
		___animator_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___animator_8), (void*)value);
	}

	inline static int32_t get_offset_of_animationSpeed_9() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___animationSpeed_9)); }
	inline float get_animationSpeed_9() const { return ___animationSpeed_9; }
	inline float* get_address_of_animationSpeed_9() { return &___animationSpeed_9; }
	inline void set_animationSpeed_9(float value)
	{
		___animationSpeed_9 = value;
	}

	inline static int32_t get_offset_of_ikHands_10() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___ikHands_10)); }
	inline IKHands_t2CD8186746290A10D977BE5B0CA9ED44513627BB * get_ikHands_10() const { return ___ikHands_10; }
	inline IKHands_t2CD8186746290A10D977BE5B0CA9ED44513627BB ** get_address_of_ikHands_10() { return &___ikHands_10; }
	inline void set_ikHands_10(IKHands_t2CD8186746290A10D977BE5B0CA9ED44513627BB * value)
	{
		___ikHands_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ikHands_10), (void*)value);
	}

	inline static int32_t get_offset_of_target_11() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___target_11)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_target_11() const { return ___target_11; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_target_11() { return &___target_11; }
	inline void set_target_11(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___target_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_11), (void*)value);
	}

	inline static int32_t get_offset_of__canAction_12() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ____canAction_12)); }
	inline bool get__canAction_12() const { return ____canAction_12; }
	inline bool* get_address_of__canAction_12() { return &____canAction_12; }
	inline void set__canAction_12(bool value)
	{
		____canAction_12 = value;
	}

	inline static int32_t get_offset_of__canFace_13() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ____canFace_13)); }
	inline bool get__canFace_13() const { return ____canFace_13; }
	inline bool* get_address_of__canFace_13() { return &____canFace_13; }
	inline void set__canFace_13(bool value)
	{
		____canFace_13 = value;
	}

	inline static int32_t get_offset_of__canMove_14() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ____canMove_14)); }
	inline bool get__canMove_14() const { return ____canMove_14; }
	inline bool* get_address_of__canMove_14() { return &____canMove_14; }
	inline void set__canMove_14(bool value)
	{
		____canMove_14 = value;
	}

	inline static int32_t get_offset_of__canStrafe_15() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ____canStrafe_15)); }
	inline bool get__canStrafe_15() const { return ____canStrafe_15; }
	inline bool* get_address_of__canStrafe_15() { return &____canStrafe_15; }
	inline void set__canStrafe_15(bool value)
	{
		____canStrafe_15 = value;
	}

	inline static int32_t get_offset_of__isAttacking_16() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ____isAttacking_16)); }
	inline bool get__isAttacking_16() const { return ____isAttacking_16; }
	inline bool* get_address_of__isAttacking_16() { return &____isAttacking_16; }
	inline void set__isAttacking_16(bool value)
	{
		____isAttacking_16 = value;
	}

	inline static int32_t get_offset_of__moveInput_17() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ____moveInput_17)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get__moveInput_17() const { return ____moveInput_17; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of__moveInput_17() { return &____moveInput_17; }
	inline void set__moveInput_17(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		____moveInput_17 = value;
	}

	inline static int32_t get_offset_of__aimInput_18() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ____aimInput_18)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get__aimInput_18() const { return ____aimInput_18; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of__aimInput_18() { return &____aimInput_18; }
	inline void set__aimInput_18(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		____aimInput_18 = value;
	}

	inline static int32_t get_offset_of__faceInput_19() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ____faceInput_19)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get__faceInput_19() const { return ____faceInput_19; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of__faceInput_19() { return &____faceInput_19; }
	inline void set__faceInput_19(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		____faceInput_19 = value;
	}

	inline static int32_t get_offset_of__jumpInput_20() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ____jumpInput_20)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get__jumpInput_20() const { return ____jumpInput_20; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of__jumpInput_20() { return &____jumpInput_20; }
	inline void set__jumpInput_20(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		____jumpInput_20 = value;
	}

	inline static int32_t get_offset_of__cameraRelativeInput_21() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ____cameraRelativeInput_21)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get__cameraRelativeInput_21() const { return ____cameraRelativeInput_21; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of__cameraRelativeInput_21() { return &____cameraRelativeInput_21; }
	inline void set__cameraRelativeInput_21(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		____cameraRelativeInput_21 = value;
	}

	inline static int32_t get_offset_of_rightWeapon_22() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___rightWeapon_22)); }
	inline int32_t get_rightWeapon_22() const { return ___rightWeapon_22; }
	inline int32_t* get_address_of_rightWeapon_22() { return &___rightWeapon_22; }
	inline void set_rightWeapon_22(int32_t value)
	{
		___rightWeapon_22 = value;
	}

	inline static int32_t get_offset_of_leftWeapon_23() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___leftWeapon_23)); }
	inline int32_t get_leftWeapon_23() const { return ___leftWeapon_23; }
	inline int32_t* get_address_of_leftWeapon_23() { return &___leftWeapon_23; }
	inline void set_leftWeapon_23(int32_t value)
	{
		___leftWeapon_23 = value;
	}

	inline static int32_t get_offset_of_actionHandlers_24() { return static_cast<int32_t>(offsetof(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19, ___actionHandlers_24)); }
	inline Dictionary_2_t681FAD08BD8140C644F9A6270F3711539ED446AE * get_actionHandlers_24() const { return ___actionHandlers_24; }
	inline Dictionary_2_t681FAD08BD8140C644F9A6270F3711539ED446AE ** get_address_of_actionHandlers_24() { return &___actionHandlers_24; }
	inline void set_actionHandlers_24(Dictionary_2_t681FAD08BD8140C644F9A6270F3711539ED446AE * value)
	{
		___actionHandlers_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___actionHandlers_24), (void*)value);
	}
};


// RPGCharacterAnims.RPGCharacterWeaponController
struct RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// RPGCharacterAnims.RPGCharacterController RPGCharacterAnims.RPGCharacterWeaponController::rpgCharacterController
	RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 * ___rpgCharacterController_4;
	// UnityEngine.Animator RPGCharacterAnims.RPGCharacterWeaponController::animator
	Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator_5;
	// RPGCharacterAnims.CoroutineQueue RPGCharacterAnims.RPGCharacterWeaponController::coroQueue
	CoroutineQueue_t68E1D1488507A988985DC27398A47D67AE2B1CF1 * ___coroQueue_6;
	// System.Boolean RPGCharacterAnims.RPGCharacterWeaponController::debugWalkthrough
	bool ___debugWalkthrough_7;
	// System.Boolean RPGCharacterAnims.RPGCharacterWeaponController::debugSwitchWeaponContext
	bool ___debugSwitchWeaponContext_8;
	// System.Boolean RPGCharacterAnims.RPGCharacterWeaponController::debugDoWeaponSwitch
	bool ___debugDoWeaponSwitch_9;
	// System.Boolean RPGCharacterAnims.RPGCharacterWeaponController::debugWeaponVisibility
	bool ___debugWeaponVisibility_10;
	// System.Boolean RPGCharacterAnims.RPGCharacterWeaponController::debugSetAnimator
	bool ___debugSetAnimator_11;
	// System.Boolean RPGCharacterAnims.RPGCharacterWeaponController::isWeaponSwitching
	bool ___isWeaponSwitching_12;
	// UnityEngine.GameObject RPGCharacterAnims.RPGCharacterWeaponController::twoHandSword
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___twoHandSword_13;

public:
	inline static int32_t get_offset_of_rpgCharacterController_4() { return static_cast<int32_t>(offsetof(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7, ___rpgCharacterController_4)); }
	inline RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 * get_rpgCharacterController_4() const { return ___rpgCharacterController_4; }
	inline RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 ** get_address_of_rpgCharacterController_4() { return &___rpgCharacterController_4; }
	inline void set_rpgCharacterController_4(RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 * value)
	{
		___rpgCharacterController_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___rpgCharacterController_4), (void*)value);
	}

	inline static int32_t get_offset_of_animator_5() { return static_cast<int32_t>(offsetof(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7, ___animator_5)); }
	inline Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * get_animator_5() const { return ___animator_5; }
	inline Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 ** get_address_of_animator_5() { return &___animator_5; }
	inline void set_animator_5(Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * value)
	{
		___animator_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___animator_5), (void*)value);
	}

	inline static int32_t get_offset_of_coroQueue_6() { return static_cast<int32_t>(offsetof(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7, ___coroQueue_6)); }
	inline CoroutineQueue_t68E1D1488507A988985DC27398A47D67AE2B1CF1 * get_coroQueue_6() const { return ___coroQueue_6; }
	inline CoroutineQueue_t68E1D1488507A988985DC27398A47D67AE2B1CF1 ** get_address_of_coroQueue_6() { return &___coroQueue_6; }
	inline void set_coroQueue_6(CoroutineQueue_t68E1D1488507A988985DC27398A47D67AE2B1CF1 * value)
	{
		___coroQueue_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___coroQueue_6), (void*)value);
	}

	inline static int32_t get_offset_of_debugWalkthrough_7() { return static_cast<int32_t>(offsetof(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7, ___debugWalkthrough_7)); }
	inline bool get_debugWalkthrough_7() const { return ___debugWalkthrough_7; }
	inline bool* get_address_of_debugWalkthrough_7() { return &___debugWalkthrough_7; }
	inline void set_debugWalkthrough_7(bool value)
	{
		___debugWalkthrough_7 = value;
	}

	inline static int32_t get_offset_of_debugSwitchWeaponContext_8() { return static_cast<int32_t>(offsetof(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7, ___debugSwitchWeaponContext_8)); }
	inline bool get_debugSwitchWeaponContext_8() const { return ___debugSwitchWeaponContext_8; }
	inline bool* get_address_of_debugSwitchWeaponContext_8() { return &___debugSwitchWeaponContext_8; }
	inline void set_debugSwitchWeaponContext_8(bool value)
	{
		___debugSwitchWeaponContext_8 = value;
	}

	inline static int32_t get_offset_of_debugDoWeaponSwitch_9() { return static_cast<int32_t>(offsetof(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7, ___debugDoWeaponSwitch_9)); }
	inline bool get_debugDoWeaponSwitch_9() const { return ___debugDoWeaponSwitch_9; }
	inline bool* get_address_of_debugDoWeaponSwitch_9() { return &___debugDoWeaponSwitch_9; }
	inline void set_debugDoWeaponSwitch_9(bool value)
	{
		___debugDoWeaponSwitch_9 = value;
	}

	inline static int32_t get_offset_of_debugWeaponVisibility_10() { return static_cast<int32_t>(offsetof(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7, ___debugWeaponVisibility_10)); }
	inline bool get_debugWeaponVisibility_10() const { return ___debugWeaponVisibility_10; }
	inline bool* get_address_of_debugWeaponVisibility_10() { return &___debugWeaponVisibility_10; }
	inline void set_debugWeaponVisibility_10(bool value)
	{
		___debugWeaponVisibility_10 = value;
	}

	inline static int32_t get_offset_of_debugSetAnimator_11() { return static_cast<int32_t>(offsetof(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7, ___debugSetAnimator_11)); }
	inline bool get_debugSetAnimator_11() const { return ___debugSetAnimator_11; }
	inline bool* get_address_of_debugSetAnimator_11() { return &___debugSetAnimator_11; }
	inline void set_debugSetAnimator_11(bool value)
	{
		___debugSetAnimator_11 = value;
	}

	inline static int32_t get_offset_of_isWeaponSwitching_12() { return static_cast<int32_t>(offsetof(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7, ___isWeaponSwitching_12)); }
	inline bool get_isWeaponSwitching_12() const { return ___isWeaponSwitching_12; }
	inline bool* get_address_of_isWeaponSwitching_12() { return &___isWeaponSwitching_12; }
	inline void set_isWeaponSwitching_12(bool value)
	{
		___isWeaponSwitching_12 = value;
	}

	inline static int32_t get_offset_of_twoHandSword_13() { return static_cast<int32_t>(offsetof(RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7, ___twoHandSword_13)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_twoHandSword_13() const { return ___twoHandSword_13; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_twoHandSword_13() { return &___twoHandSword_13; }
	inline void set_twoHandSword_13(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___twoHandSword_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___twoHandSword_13), (void*)value);
	}
};


// SuperStateMachine
struct SuperStateMachine_t4E8C90DE14D70B59C2BFB44B915DAF19434A1F35  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Single SuperStateMachine::timeEnteredState
	float ___timeEnteredState_4;
	// SuperStateMachine/State SuperStateMachine::state
	State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD * ___state_5;
	// System.Enum SuperStateMachine::lastState
	Enum_t23B90B40F60E677A8025267341651C94AE079CDA * ___lastState_6;
	// System.Collections.Generic.Dictionary`2<System.Enum,System.Collections.Generic.Dictionary`2<System.String,System.Delegate>> SuperStateMachine::_cache
	Dictionary_2_tDE192EFC3F4EFFED7FE11B34697861F229089C8F * ____cache_7;

public:
	inline static int32_t get_offset_of_timeEnteredState_4() { return static_cast<int32_t>(offsetof(SuperStateMachine_t4E8C90DE14D70B59C2BFB44B915DAF19434A1F35, ___timeEnteredState_4)); }
	inline float get_timeEnteredState_4() const { return ___timeEnteredState_4; }
	inline float* get_address_of_timeEnteredState_4() { return &___timeEnteredState_4; }
	inline void set_timeEnteredState_4(float value)
	{
		___timeEnteredState_4 = value;
	}

	inline static int32_t get_offset_of_state_5() { return static_cast<int32_t>(offsetof(SuperStateMachine_t4E8C90DE14D70B59C2BFB44B915DAF19434A1F35, ___state_5)); }
	inline State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD * get_state_5() const { return ___state_5; }
	inline State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD ** get_address_of_state_5() { return &___state_5; }
	inline void set_state_5(State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD * value)
	{
		___state_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___state_5), (void*)value);
	}

	inline static int32_t get_offset_of_lastState_6() { return static_cast<int32_t>(offsetof(SuperStateMachine_t4E8C90DE14D70B59C2BFB44B915DAF19434A1F35, ___lastState_6)); }
	inline Enum_t23B90B40F60E677A8025267341651C94AE079CDA * get_lastState_6() const { return ___lastState_6; }
	inline Enum_t23B90B40F60E677A8025267341651C94AE079CDA ** get_address_of_lastState_6() { return &___lastState_6; }
	inline void set_lastState_6(Enum_t23B90B40F60E677A8025267341651C94AE079CDA * value)
	{
		___lastState_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___lastState_6), (void*)value);
	}

	inline static int32_t get_offset_of__cache_7() { return static_cast<int32_t>(offsetof(SuperStateMachine_t4E8C90DE14D70B59C2BFB44B915DAF19434A1F35, ____cache_7)); }
	inline Dictionary_2_tDE192EFC3F4EFFED7FE11B34697861F229089C8F * get__cache_7() const { return ____cache_7; }
	inline Dictionary_2_tDE192EFC3F4EFFED7FE11B34697861F229089C8F ** get_address_of__cache_7() { return &____cache_7; }
	inline void set__cache_7(Dictionary_2_tDE192EFC3F4EFFED7FE11B34697861F229089C8F * value)
	{
		____cache_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____cache_7), (void*)value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Delegate_t * m_Items[1];

public:
	inline Delegate_t * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};



// System.Void System.Action::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action__ctor_m07BE5EE8A629FBBA52AE6356D57A0D371BE2574B (Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void RPGCharacterAnims.RPGCharacterWeaponController::SyncWeaponVisibility()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RPGCharacterWeaponController_SyncWeaponVisibility_mCA2268C5A4CDBFE1C58BBAED5AFC627725CA91D6 (RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7 * __this, const RuntimeMethod* method);
// System.Void SuperCharacterController/SuperGround/GroundHit::set_point(UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GroundHit_set_point_mD2DFF334DC1B71D33E0EE19616E9B25D56FF47DE_inline (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Void SuperCharacterController/SuperGround/GroundHit::set_normal(UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GroundHit_set_normal_mD2ED0F20A538F5409BA8C06F6A8056B1C4641B4B_inline (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Void SuperCharacterController/SuperGround/GroundHit::set_distance(System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GroundHit_set_distance_m49F38D09A08B448BCCBE35AD454C8F614616D3BE_inline (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, float ___value0, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_UpdateDelegate_t61C37A9FBEC6671FAF75E6914BF252417C0D9F4F (UpdateDelegate_t61C37A9FBEC6671FAF75E6914BF252417C0D9F4F * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void SuperCharacterController/UpdateDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpdateDelegate__ctor_m69C25AB9EA029AC2BDCEF5282E45ADF3AB3418AF (UpdateDelegate_t61C37A9FBEC6671FAF75E6914BF252417C0D9F4F * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void SuperCharacterController/UpdateDelegate::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpdateDelegate_Invoke_m3B1A8722CE871383E5D9D4916F5F1EFDACDDE01B (UpdateDelegate_t61C37A9FBEC6671FAF75E6914BF252417C0D9F4F * __this, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 0)
			{
				// open
				typedef void (*FunctionPointerType) (const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, targetThis);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, targetThis);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
	}
}
// System.IAsyncResult SuperCharacterController/UpdateDelegate::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* UpdateDelegate_BeginInvoke_m58E72D637AF7049B8EBB4BF5A59F3A6A0ED4AE89 (UpdateDelegate_t61C37A9FBEC6671FAF75E6914BF252417C0D9F4F * __this, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);;
}
// System.Void SuperCharacterController/UpdateDelegate::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpdateDelegate_EndInvoke_m17688328E5916F4C6A7513664F32904DBE519BCC (UpdateDelegate_t61C37A9FBEC6671FAF75E6914BF252417C0D9F4F * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void SuperStateMachine/State::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void State__ctor_m2EF844EB75FFA4BFA7E7878CED14B95DAA9E9073 (State_t0847E1038C0873230AEA01CBAB6D8561956C4BCD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SuperStateMachine_DoNothing_m203B2026577A03CF9EA025EAE48DD692639629FA_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public Action DoSuperUpdate = DoNothing;
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_0 = (Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 *)il2cpp_codegen_object_new(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6_il2cpp_TypeInfo_var);
		Action__ctor_m07BE5EE8A629FBBA52AE6356D57A0D371BE2574B(L_0, NULL, (intptr_t)((intptr_t)SuperStateMachine_DoNothing_m203B2026577A03CF9EA025EAE48DD692639629FA_RuntimeMethod_var), /*hidden argument*/NULL);
		__this->set_DoSuperUpdate_0(L_0);
		// public Action enterState = DoNothing;
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_1 = (Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 *)il2cpp_codegen_object_new(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6_il2cpp_TypeInfo_var);
		Action__ctor_m07BE5EE8A629FBBA52AE6356D57A0D371BE2574B(L_1, NULL, (intptr_t)((intptr_t)SuperStateMachine_DoNothing_m203B2026577A03CF9EA025EAE48DD692639629FA_RuntimeMethod_var), /*hidden argument*/NULL);
		__this->set_enterState_1(L_1);
		// public Action exitState = DoNothing;
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_2 = (Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 *)il2cpp_codegen_object_new(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6_il2cpp_TypeInfo_var);
		Action__ctor_m07BE5EE8A629FBBA52AE6356D57A0D371BE2574B(L_2, NULL, (intptr_t)((intptr_t)SuperStateMachine_DoNothing_m203B2026577A03CF9EA025EAE48DD692639629FA_RuntimeMethod_var), /*hidden argument*/NULL);
		__this->set_exitState_2(L_2);
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_0__ctor_m8022BCAF804539E042D050C7C8A0A7F4A1254DE3 (U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void RPGCharacterAnims.Actions.SwitchWeapon/<>c__DisplayClass3_0::<EndSwitch>b__0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_0_U3CEndSwitchU3Eb__0_m19D617A48B6444BDD112292B5B3415D772B97610 (U3CU3Ec__DisplayClass3_0_tD13D36B6138D97D55EC64303DFF822778D1BDE42 * __this, const RuntimeMethod* method)
{
	{
		// if (changeLeft) { controller.leftWeapon = toLeftWeapon; }
		bool L_0 = __this->get_changeLeft_0();
		if (!L_0)
		{
			goto IL_0019;
		}
	}
	{
		// if (changeLeft) { controller.leftWeapon = toLeftWeapon; }
		RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 * L_1 = __this->get_controller_1();
		int32_t L_2 = __this->get_toLeftWeapon_2();
		NullCheck(L_1);
		L_1->set_leftWeapon_23(L_2);
	}

IL_0019:
	{
		// if (changeRight) { controller.rightWeapon = toRightWeapon; }
		bool L_3 = __this->get_changeRight_3();
		if (!L_3)
		{
			goto IL_0032;
		}
	}
	{
		// if (changeRight) { controller.rightWeapon = toRightWeapon; }
		RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 * L_4 = __this->get_controller_1();
		int32_t L_5 = __this->get_toRightWeapon_4();
		NullCheck(L_4);
		L_4->set_rightWeapon_22(L_5);
	}

IL_0032:
	{
		// weaponController.SyncWeaponVisibility();
		RPGCharacterWeaponController_t1186B0FAEB6AC553503E3BABC249BD8073A353A7 * L_6 = __this->get_weaponController_5();
		NullCheck(L_6);
		RPGCharacterWeaponController_SyncWeaponVisibility_mCA2268C5A4CDBFE1C58BBAED5AFC627725CA91D6(L_6, /*hidden argument*/NULL);
		// EndAction(controller);
		SwitchWeapon_tFC5CDE1644522BF7B2F853721E41C9548F244226 * L_7 = __this->get_U3CU3E4__this_6();
		RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 * L_8 = __this->get_controller_1();
		NullCheck(L_7);
		VirtActionInvoker1< RPGCharacterController_t70555ADCC3062A95C5FE03AE2BD44F1A76BC2E19 * >::Invoke(20 /* System.Void RPGCharacterAnims.Actions.BaseActionHandler`1<RPGCharacterAnims.Actions.SwitchWeaponContext>::EndAction(RPGCharacterAnims.RPGCharacterController) */, L_7, L_8);
		// });
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Vector3 SuperCharacterController/SuperGround/GroundHit::get_point()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  GroundHit_get_point_m23F49DFD517AC9F37753A1AC3FDEB9788AB5C9E6 (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, const RuntimeMethod* method)
{
	{
		// public Vector3 point { get; private set; }
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = __this->get_U3CpointU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void SuperCharacterController/SuperGround/GroundHit::set_point(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GroundHit_set_point_mD2DFF334DC1B71D33E0EE19616E9B25D56FF47DE (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method)
{
	{
		// public Vector3 point { get; private set; }
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___value0;
		__this->set_U3CpointU3Ek__BackingField_0(L_0);
		return;
	}
}
// UnityEngine.Vector3 SuperCharacterController/SuperGround/GroundHit::get_normal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  GroundHit_get_normal_mBA93744A7C9AFA06E3F00BBB06A5343EB53665C3 (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, const RuntimeMethod* method)
{
	{
		// public Vector3 normal { get; private set; }
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = __this->get_U3CnormalU3Ek__BackingField_1();
		return L_0;
	}
}
// System.Void SuperCharacterController/SuperGround/GroundHit::set_normal(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GroundHit_set_normal_mD2ED0F20A538F5409BA8C06F6A8056B1C4641B4B (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method)
{
	{
		// public Vector3 normal { get; private set; }
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___value0;
		__this->set_U3CnormalU3Ek__BackingField_1(L_0);
		return;
	}
}
// System.Single SuperCharacterController/SuperGround/GroundHit::get_distance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GroundHit_get_distance_m21A6DFE8F4BC011B5F57CC79DEF3D6BB7DAC6963 (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, const RuntimeMethod* method)
{
	{
		// public float distance { get; private set; }
		float L_0 = __this->get_U3CdistanceU3Ek__BackingField_2();
		return L_0;
	}
}
// System.Void SuperCharacterController/SuperGround/GroundHit::set_distance(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GroundHit_set_distance_m49F38D09A08B448BCCBE35AD454C8F614616D3BE (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, float ___value0, const RuntimeMethod* method)
{
	{
		// public float distance { get; private set; }
		float L_0 = ___value0;
		__this->set_U3CdistanceU3Ek__BackingField_2(L_0);
		return;
	}
}
// System.Void SuperCharacterController/SuperGround/GroundHit::.ctor(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GroundHit__ctor_m9C5BA2C1D9B27270E1CCD6137CD62BCDF919A58E (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___point0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___normal1, float ___distance2, const RuntimeMethod* method)
{
	{
		// public GroundHit(Vector3 point, Vector3 normal, float distance)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// this.point = point;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___point0;
		GroundHit_set_point_mD2DFF334DC1B71D33E0EE19616E9B25D56FF47DE_inline(__this, L_0, /*hidden argument*/NULL);
		// this.normal = normal;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1 = ___normal1;
		GroundHit_set_normal_mD2ED0F20A538F5409BA8C06F6A8056B1C4641B4B_inline(__this, L_1, /*hidden argument*/NULL);
		// this.distance = distance;
		float L_2 = ___distance2;
		GroundHit_set_distance_m49F38D09A08B448BCCBE35AD454C8F614616D3BE_inline(__this, L_2, /*hidden argument*/NULL);
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GroundHit_set_point_mD2DFF334DC1B71D33E0EE19616E9B25D56FF47DE_inline (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method)
{
	{
		// public Vector3 point { get; private set; }
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___value0;
		__this->set_U3CpointU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GroundHit_set_normal_mD2ED0F20A538F5409BA8C06F6A8056B1C4641B4B_inline (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method)
{
	{
		// public Vector3 normal { get; private set; }
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___value0;
		__this->set_U3CnormalU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GroundHit_set_distance_m49F38D09A08B448BCCBE35AD454C8F614616D3BE_inline (GroundHit_t1E0A36293749A79815487FD0462CF94DB5334FDA * __this, float ___value0, const RuntimeMethod* method)
{
	{
		// public float distance { get; private set; }
		float L_0 = ___value0;
		__this->set_U3CdistanceU3Ek__BackingField_2(L_0);
		return;
	}
}
