#import <Foundation/Foundation.h>
#import "../swift/Sources/Crashy/crashy.h"

NS_ASSUME_NONNULL_BEGIN

void throwObjectiveCException()
{
#ifdef __EXCEPTIONS
    NSLog(@"Objective-C: Throwing an Exception");
    @throw [NSException exceptionWithName:@"Objective-C Exception"
                                   reason:@"Testing crashes."
                                 userInfo:@{@"AdditionalInfo":@"WithAdditionalValue"}];
#else
    NSLog(@"Objective-C: Exceptions are disabled. "
           "Consider enabling it on Xcode project: "
           "GCC_ENABLE_OBJC_EXCEPTIONS");
#endif
}

void segfault()
{
    NSLog(@"Objective-C: Crashing");
    int *p = 0;
    *p = 0;
}

void callSwift()
{
    CrashySwift *crashy = [[CrashySwift alloc] init];
    [crashy divideByZero];
}

NS_ASSUME_NONNULL_END

@end
