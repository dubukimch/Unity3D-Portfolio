#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Boolean UnityEngine.AI.NavMeshAgent::SetDestination(UnityEngine.Vector3)
extern void NavMeshAgent_SetDestination_m244EFBCDB717576303DA711EE39572B865F43747 (void);
// 0x00000002 UnityEngine.Vector3 UnityEngine.AI.NavMeshAgent::get_destination()
extern void NavMeshAgent_get_destination_m0FDF371CBF97028F28416675134875122F13AD2F (void);
// 0x00000003 UnityEngine.Vector3 UnityEngine.AI.NavMeshAgent::get_velocity()
extern void NavMeshAgent_get_velocity_mA6F25F6B38D5092BBE6DECD77F8FDB93D5C515C9 (void);
// 0x00000004 System.Boolean UnityEngine.AI.NavMeshAgent::get_hasPath()
extern void NavMeshAgent_get_hasPath_m0FD535ACA98272F1C5082C7EE600ECCB66F044CB (void);
// 0x00000005 System.Single UnityEngine.AI.NavMeshAgent::get_speed()
extern void NavMeshAgent_get_speed_m5AA9A1B23412A8F5CE24A5312F6E6D4BA282B173 (void);
// 0x00000006 System.Void UnityEngine.AI.NavMeshAgent::set_speed(System.Single)
extern void NavMeshAgent_set_speed_mE71CB504B0CC1E977293722F9BA81B7060A99E14 (void);
// 0x00000007 System.Single UnityEngine.AI.NavMeshAgent::get_angularSpeed()
extern void NavMeshAgent_get_angularSpeed_mD38E53E3ECA7E21749A8546C8DC91C56908066AA (void);
// 0x00000008 System.Boolean UnityEngine.AI.NavMeshAgent::SetDestination_Injected(UnityEngine.Vector3&)
extern void NavMeshAgent_SetDestination_Injected_m41607AA111EE126BBBDCDDF76B7523B0BC369D9A (void);
// 0x00000009 System.Void UnityEngine.AI.NavMeshAgent::get_destination_Injected(UnityEngine.Vector3&)
extern void NavMeshAgent_get_destination_Injected_m494AB78E64E0F2835BF8FFE6A60A71E199474A00 (void);
// 0x0000000A System.Void UnityEngine.AI.NavMeshAgent::get_velocity_Injected(UnityEngine.Vector3&)
extern void NavMeshAgent_get_velocity_Injected_m64CD1C3DAE418314D44A1194F014CEC159CDDAA8 (void);
// 0x0000000B System.Void UnityEngine.AI.NavMesh::Internal_CallOnNavMeshPreUpdate()
extern void NavMesh_Internal_CallOnNavMeshPreUpdate_m5C0CEF0AEF92B6BE0368AA5ABC02B4CCDEFA9AD5 (void);
// 0x0000000C System.Void UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::.ctor(System.Object,System.IntPtr)
extern void OnNavMeshPreUpdate__ctor_mDBB85480C3EA968112EB3B356486B9C9FF387BD4 (void);
// 0x0000000D System.Void UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::Invoke()
extern void OnNavMeshPreUpdate_Invoke_m8950FEDFD3E07B272ED469FD1911AA98C60FC28D (void);
// 0x0000000E System.IAsyncResult UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::BeginInvoke(System.AsyncCallback,System.Object)
extern void OnNavMeshPreUpdate_BeginInvoke_m8B7FF1B745E38190A2B744775602508E77B291FA (void);
// 0x0000000F System.Void UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::EndInvoke(System.IAsyncResult)
extern void OnNavMeshPreUpdate_EndInvoke_mA263F64ADF01540E24327DDB24BD334539B1B4D2 (void);
static Il2CppMethodPointer s_methodPointers[15] = 
{
	NavMeshAgent_SetDestination_m244EFBCDB717576303DA711EE39572B865F43747,
	NavMeshAgent_get_destination_m0FDF371CBF97028F28416675134875122F13AD2F,
	NavMeshAgent_get_velocity_mA6F25F6B38D5092BBE6DECD77F8FDB93D5C515C9,
	NavMeshAgent_get_hasPath_m0FD535ACA98272F1C5082C7EE600ECCB66F044CB,
	NavMeshAgent_get_speed_m5AA9A1B23412A8F5CE24A5312F6E6D4BA282B173,
	NavMeshAgent_set_speed_mE71CB504B0CC1E977293722F9BA81B7060A99E14,
	NavMeshAgent_get_angularSpeed_mD38E53E3ECA7E21749A8546C8DC91C56908066AA,
	NavMeshAgent_SetDestination_Injected_m41607AA111EE126BBBDCDDF76B7523B0BC369D9A,
	NavMeshAgent_get_destination_Injected_m494AB78E64E0F2835BF8FFE6A60A71E199474A00,
	NavMeshAgent_get_velocity_Injected_m64CD1C3DAE418314D44A1194F014CEC159CDDAA8,
	NavMesh_Internal_CallOnNavMeshPreUpdate_m5C0CEF0AEF92B6BE0368AA5ABC02B4CCDEFA9AD5,
	OnNavMeshPreUpdate__ctor_mDBB85480C3EA968112EB3B356486B9C9FF387BD4,
	OnNavMeshPreUpdate_Invoke_m8950FEDFD3E07B272ED469FD1911AA98C60FC28D,
	OnNavMeshPreUpdate_BeginInvoke_m8B7FF1B745E38190A2B744775602508E77B291FA,
	OnNavMeshPreUpdate_EndInvoke_mA263F64ADF01540E24327DDB24BD334539B1B4D2,
};
static const int32_t s_InvokerIndices[15] = 
{
	1032,
	1321,
	1321,
	1309,
	1312,
	1149,
	1312,
	956,
	1094,
	1094,
	2238,
	742,
	1323,
	566,
	1130,
};
extern const CustomAttributesCacheGenerator g_UnityEngine_AIModule_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_UnityEngine_AIModule_CodeGenModule;
const Il2CppCodeGenModule g_UnityEngine_AIModule_CodeGenModule = 
{
	"UnityEngine.AIModule.dll",
	15,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	g_UnityEngine_AIModule_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
