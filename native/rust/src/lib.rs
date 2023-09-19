use std::ffi::CStr;
use std::os::raw::c_char;

#[no_mangle]
pub extern "C" fn panicky(to: *const c_char) {
    let c_str = unsafe { CStr::from_ptr(to) };
    panic!("panic: {:#?}", c_str);
}