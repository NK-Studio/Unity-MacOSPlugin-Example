#import "DemoCode.h"


@implementation DemoCode

- (void)UseDemo {
    NSUnityLog("Hello World");
}

@end

extern "C"
{
    void UseDemo()
    {
        DemoCode *demoCode = [[DemoCode alloc] init];
        [demoCode UseDemo];
    }
}