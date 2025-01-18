use warp::Filter;

#[tokio::main]
async fn main() {
    let routes = warp::path("game")
        .and(warp::get())
        .map(|| warp::reply::json(&"Welcome to the Cosmic Colony!"));

    println!("Server running on http://127.0.0.1:3030");
    warp::serve(routes).run(([127, 0, 0, 1], 3030)).await;
}
