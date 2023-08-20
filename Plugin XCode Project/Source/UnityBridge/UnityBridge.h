#import <Foundation/Foundation.h>

typedef void (*UnityLogCallback)(const char* callback);

extern "C"
{
    void NSUnityLogCallback(UnityLogCallback callback);
    void NSUnityLog(NSString* log);
}
