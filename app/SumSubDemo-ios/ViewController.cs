using Foundation;
using SumSubstance.iOS;
using System;
using UIKit;

namespace SumSubDemo_ios
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            StartKyc();

        }

        private void StartKyc()
        {
            SSEngine kycEngine = SumSubSdkHelper.GetInstance();

            // https://developers.sumsub.com/msdk/ios.html#usage
            // Then you should:

            // Connect to remote - [engine connectWithExpirationHandler:verificationResultHandler:]
            // -
            kycEngine.ConnectWithExpirationHandler(
                tokenExpirationHandler: () =>
                {
                    // TODO: better error handling in production app
                    // -
                    Console.WriteLine("[connect] Token Expired");

                    // refresh example :
                    // https://github.com/SumSubstance/KYC-iOS-Demo/blob/master/Demo/Logic/Coordinator.m#L242
                },
                verificationResultHandler: (isVerificationOk) =>
                {
                    // [alex-d] it's ok to not proceed in this callback according to vendor's sample
                    // seems like `ConnectWithExpirationHandler()` is performed in synchronous and blocking manner
                    // so this might affect app performance
                    // -

                    Console.WriteLine($"[connect] verification done. IsVerified={isVerificationOk}");
                });

            kycEngine.OnActionEvent += (ssActionEventInfo) =>
            {
                Console.WriteLine($"[kyc] action received. Step={ssActionEventInfo.FlowStep}");
            };


            var formattedChatTitle = new NSAttributedString("SumSub KYC iOS demo");
            UINavigationController chatViewController =
                SSFacade.GetChatControllerWithAttributedTitle(title: formattedChatTitle);

            this.NavigationController.PresentViewController(
                viewControllerToPresent: chatViewController,
                animated: true,
                completionHandler: () =>
                {
                    Console.WriteLine("[kyc] [chat] Chat VC presented");
                });

            // TODO: dispose chat properly
            // https://github.com/SumSubstance/KYC-iOS-Demo/blob/master/Demo/Logic/Coordinator.m#L271
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}