#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

void ()
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

NS_ASSUME_NONNULL_END
