#[link(name = "math_operations")]
extern "C" {
    fn add(a: f32, b: f32);
    fn subtract(a: f32, b: f32);
}

fn main() {
    unsafe {
        add(5.0, 3.0);
        subtract(5.0, 3.0);
    }
}
