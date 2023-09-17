import Foundation

@objc
public class CrashySwift: NSObject {
    var zero = 0
    @objc
    public func divideByZero() {
        print("Swift: dividing by zero")
        _ = 1 / zero
    }
}

// fatalError()
// preconditionFailure()
