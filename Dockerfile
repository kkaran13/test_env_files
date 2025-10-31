# ✅ True positives
ENV API_KEY=example
ARG BUILD_ENV=production

# ❌ False positives
RUN echo "true" && echo "none"
