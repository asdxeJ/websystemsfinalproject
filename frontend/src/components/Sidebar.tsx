import { useState } from "react";
import { ShoppingCart } from "lucide-react"; // Icon for cart

const Sidebar = () => {
  const [isCartVisible, setIsCartVisible] = useState(false);

  const toggleCart = () => {
    setIsCartVisible(!isCartVisible);
  };

  return (
    <div>
      {/* Cart Icon */}
      <div className="cursor-pointer" onClick={toggleCart}>
        <ShoppingCart className="text-orange-600" size={32} />
        <span className="text-white">Cart</span>
      </div>

      {/* Cart Sidebar */}
      {isCartVisible && (
        <div className="fixed top-0 right-0 bg-gray-800 text-white w-64 h-full shadow-lg p-4 z-50">
          <h2 className="text-xl font-bold">My Cart</h2>
          <div className="overflow-y-auto mt-4">
            {/* Cart items will be shown here */}
            <p>Your cart is empty!</p>
            {/* You can map through cart items and display them here */}
          </div>
          <div className="mt-4">
            <button className="bg-orange-600 text-white py-2 px-4 rounded">
              Checkout
            </button>
          </div>
        </div>
      )}
    </div>
  );
};

export default Sidebar;
