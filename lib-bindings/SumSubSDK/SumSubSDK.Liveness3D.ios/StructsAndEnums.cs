using ObjCRuntime;

namespace SumSubstance.Liveness3D.iOS
{
	[Native]
	public enum SSLiveness3DStatus : long
	{
		Cancelled,
		InitializationFailed,
		CameraPermissionDenied,
		TokenIsInvalid,
		FaceMismatched,
		VerificationPassedSuccessfully
	}
}
