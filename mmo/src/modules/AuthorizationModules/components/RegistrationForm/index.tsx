import React, { useState } from "react";

const RegistrationForm: React.FC = () => {
  const [email, setEmail] = useState<string>("");
  const [login, setLogin] = useState<string>("");
  const [password, setPassword] = useState<string>("");

  const handleSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    // Добавьте здесь логику для отправки формы регистрации на сервер
  };

  return (
    <div>
      <form onSubmit={handleSubmit} className="w-64">
        <input
          className="mb-4 w-full rounded border p-2"
          onChange={(e) => setEmail(e.target.value)}
          value={email}
          type="email"
          placeholder="Email"
          required
        />
        <input
          className="mb-4 w-full rounded border p-2"
          onChange={(e) => setLogin(e.target.value)}
          value={login}
          type="text"
          placeholder="Login"
          required
        />
        <input
          className="mb-4 w-full rounded border p-2"
          onChange={(e) => setPassword(e.target.value)}
          value={password}
          type="password"
          placeholder="Password"
          required
        />
        <div className="flex justify-between">
          <button
            className="rounded border-2 border-black bg-red-700 px-4 py-2 
            text-gold shadow-inner"
          >
            Зарегистрироваться
          </button>
        </div>
      </form>
    </div>
  );
};

export { RegistrationForm };
