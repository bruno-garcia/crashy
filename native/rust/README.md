Compiling:

```
rm libcrashy_rust.dylib
cargo build --target=aarch64-apple-darwin --release
cargo build --target=x86_64-apple-darwin --release
lipo target/aarch64-apple-darwin/release/libcrashy_rust.dylib \
    target/x86_64-apple-darwin/release/libcrashy_rust.dylib \
    -create -output libcrashy_rust.dylib
```
