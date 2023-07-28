import React, { useState } from "react";

const AuthorizationForm: React.FC = () => {
  const [email, setEmail] = useState<string>("");
  const [password, setPassword] = useState<string>("");

  return (
    <div className="flex h-screen items-center justify-center">
      <div className="w-64">
        <input
          className="mb-4 w-full rounded border p-2"
          onChange={(e) => setEmail(e.target.value)}
          value={email}
          type="text"
          placeholder="Email"
        />
        <input
          className="mb-4 w-full rounded border p-2"
          onChange={(e) => setPassword(e.target.value)}
          value={password}
          type="password"
          placeholder="Password"
        />
        <div className="flex justify-between">
          <button className="rounded bg-blue-500 px-4 py-2 text-white">
            Авторизация
          </button>
          <button className="rounded bg-gray-500 px-4 py-2 text-white">
            Регистрация
          </button>
        </div>
      </div>
    </div>
  );
};

export { AuthorizationForm };
