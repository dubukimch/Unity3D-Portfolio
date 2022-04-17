#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>



// System.String
struct String_t;
// UnityEngine.TerrainCollider
struct TerrainCollider_t7B0DDF9DE78C22137804E29293567456BDDB9D9F;
// UnityEngine.TerrainData
struct TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;



IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t36F91C5638F951949BEF9447BB9805D0532808EB 
{
public:

public:
};


// System.Object

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

// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.TerrainData
struct TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};

struct TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4_StaticFields
{
public:
	// System.Int32 UnityEngine.TerrainData::k_MaximumResolution
	int32_t ___k_MaximumResolution_4;
	// System.Int32 UnityEngine.TerrainData::k_MinimumDetailResolutionPerPatch
	int32_t ___k_MinimumDetailResolutionPerPatch_5;
	// System.Int32 UnityEngine.TerrainData::k_MaximumDetailResolutionPerPatch
	int32_t ___k_MaximumDetailResolutionPerPatch_6;
	// System.Int32 UnityEngine.TerrainData::k_MaximumDetailPatchCount
	int32_t ___k_MaximumDetailPatchCount_7;
	// System.Int32 UnityEngine.TerrainData::k_MaximumDetailsPerRes
	int32_t ___k_MaximumDetailsPerRes_8;
	// System.Int32 UnityEngine.TerrainData::k_MinimumAlphamapResolution
	int32_t ___k_MinimumAlphamapResolution_9;
	// System.Int32 UnityEngine.TerrainData::k_MaximumAlphamapResolution
	int32_t ___k_MaximumAlphamapResolution_10;
	// System.Int32 UnityEngine.TerrainData::k_MinimumBaseMapResolution
	int32_t ___k_MinimumBaseMapResolution_11;
	// System.Int32 UnityEngine.TerrainData::k_MaximumBaseMapResolution
	int32_t ___k_MaximumBaseMapResolution_12;

public:
	inline static int32_t get_offset_of_k_MaximumResolution_4() { return static_cast<int32_t>(offsetof(TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4_StaticFields, ___k_MaximumResolution_4)); }
	inline int32_t get_k_MaximumResolution_4() const { return ___k_MaximumResolution_4; }
	inline int32_t* get_address_of_k_MaximumResolution_4() { return &___k_MaximumResolution_4; }
	inline void set_k_MaximumResolution_4(int32_t value)
	{
		___k_MaximumResolution_4 = value;
	}

	inline static int32_t get_offset_of_k_MinimumDetailResolutionPerPatch_5() { return static_cast<int32_t>(offsetof(TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4_StaticFields, ___k_MinimumDetailResolutionPerPatch_5)); }
	inline int32_t get_k_MinimumDetailResolutionPerPatch_5() const { return ___k_MinimumDetailResolutionPerPatch_5; }
	inline int32_t* get_address_of_k_MinimumDetailResolutionPerPatch_5() { return &___k_MinimumDetailResolutionPerPatch_5; }
	inline void set_k_MinimumDetailResolutionPerPatch_5(int32_t value)
	{
		___k_MinimumDetailResolutionPerPatch_5 = value;
	}

	inline static int32_t get_offset_of_k_MaximumDetailResolutionPerPatch_6() { return static_cast<int32_t>(offsetof(TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4_StaticFields, ___k_MaximumDetailResolutionPerPatch_6)); }
	inline int32_t get_k_MaximumDetailResolutionPerPatch_6() const { return ___k_MaximumDetailResolutionPerPatch_6; }
	inline int32_t* get_address_of_k_MaximumDetailResolutionPerPatch_6() { return &___k_MaximumDetailResolutionPerPatch_6; }
	inline void set_k_MaximumDetailResolutionPerPatch_6(int32_t value)
	{
		___k_MaximumDetailResolutionPerPatch_6 = value;
	}

	inline static int32_t get_offset_of_k_MaximumDetailPatchCount_7() { return static_cast<int32_t>(offsetof(TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4_StaticFields, ___k_MaximumDetailPatchCount_7)); }
	inline int32_t get_k_MaximumDetailPatchCount_7() const { return ___k_MaximumDetailPatchCount_7; }
	inline int32_t* get_address_of_k_MaximumDetailPatchCount_7() { return &___k_MaximumDetailPatchCount_7; }
	inline void set_k_MaximumDetailPatchCount_7(int32_t value)
	{
		___k_MaximumDetailPatchCount_7 = value;
	}

	inline static int32_t get_offset_of_k_MaximumDetailsPerRes_8() { return static_cast<int32_t>(offsetof(TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4_StaticFields, ___k_MaximumDetailsPerRes_8)); }
	inline int32_t get_k_MaximumDetailsPerRes_8() const { return ___k_MaximumDetailsPerRes_8; }
	inline int32_t* get_address_of_k_MaximumDetailsPerRes_8() { return &___k_MaximumDetailsPerRes_8; }
	inline void set_k_MaximumDetailsPerRes_8(int32_t value)
	{
		___k_MaximumDetailsPerRes_8 = value;
	}

	inline static int32_t get_offset_of_k_MinimumAlphamapResolution_9() { return static_cast<int32_t>(offsetof(TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4_StaticFields, ___k_MinimumAlphamapResolution_9)); }
	inline int32_t get_k_MinimumAlphamapResolution_9() const { return ___k_MinimumAlphamapResolution_9; }
	inline int32_t* get_address_of_k_MinimumAlphamapResolution_9() { return &___k_MinimumAlphamapResolution_9; }
	inline void set_k_MinimumAlphamapResolution_9(int32_t value)
	{
		___k_MinimumAlphamapResolution_9 = value;
	}

	inline static int32_t get_offset_of_k_MaximumAlphamapResolution_10() { return static_cast<int32_t>(offsetof(TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4_StaticFields, ___k_MaximumAlphamapResolution_10)); }
	inline int32_t get_k_MaximumAlphamapResolution_10() const { return ___k_MaximumAlphamapResolution_10; }
	inline int32_t* get_address_of_k_MaximumAlphamapResolution_10() { return &___k_MaximumAlphamapResolution_10; }
	inline void set_k_MaximumAlphamapResolution_10(int32_t value)
	{
		___k_MaximumAlphamapResolution_10 = value;
	}

	inline static int32_t get_offset_of_k_MinimumBaseMapResolution_11() { return static_cast<int32_t>(offsetof(TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4_StaticFields, ___k_MinimumBaseMapResolution_11)); }
	inline int32_t get_k_MinimumBaseMapResolution_11() const { return ___k_MinimumBaseMapResolution_11; }
	inline int32_t* get_address_of_k_MinimumBaseMapResolution_11() { return &___k_MinimumBaseMapResolution_11; }
	inline void set_k_MinimumBaseMapResolution_11(int32_t value)
	{
		___k_MinimumBaseMapResolution_11 = value;
	}

	inline static int32_t get_offset_of_k_MaximumBaseMapResolution_12() { return static_cast<int32_t>(offsetof(TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4_StaticFields, ___k_MaximumBaseMapResolution_12)); }
	inline int32_t get_k_MaximumBaseMapResolution_12() const { return ___k_MaximumBaseMapResolution_12; }
	inline int32_t* get_address_of_k_MaximumBaseMapResolution_12() { return &___k_MaximumBaseMapResolution_12; }
	inline void set_k_MaximumBaseMapResolution_12(int32_t value)
	{
		___k_MaximumBaseMapResolution_12 = value;
	}
};


// UnityEngine.Collider
struct Collider_t5E81E43C2ECA0209A7C4528E84A632712D192B02  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// UnityEngine.TerrainCollider
struct TerrainCollider_t7B0DDF9DE78C22137804E29293567456BDDB9D9F  : public Collider_t5E81E43C2ECA0209A7C4528E84A632712D192B02
{
public:

public:
};

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
// UnityEngine.TerrainData UnityEngine.TerrainCollider::get_terrainData()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4 * TerrainCollider_get_terrainData_m2A58531B47F4E61286A3E4B787869BFFADA56D37 (TerrainCollider_t7B0DDF9DE78C22137804E29293567456BDDB9D9F * __this, const RuntimeMethod* method)
{
	typedef TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4 * (*TerrainCollider_get_terrainData_m2A58531B47F4E61286A3E4B787869BFFADA56D37_ftn) (TerrainCollider_t7B0DDF9DE78C22137804E29293567456BDDB9D9F *);
	static TerrainCollider_get_terrainData_m2A58531B47F4E61286A3E4B787869BFFADA56D37_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (TerrainCollider_get_terrainData_m2A58531B47F4E61286A3E4B787869BFFADA56D37_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.TerrainCollider::get_terrainData()");
	TerrainData_tAD3780D3C4DE5B9BE122BECE6D08C4AE169ED2A4 * icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
